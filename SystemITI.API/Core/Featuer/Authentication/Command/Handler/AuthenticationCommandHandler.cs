using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Shared.Absractions;
using System.Security.Cryptography;
using SystemITI.API.Core.Featuer.Authentication.Command.Models;
using SystemITI.API.Core.Featuer.Authentication.Command.Results;
using SystemITI.API.Entity;
using SystemITI.API.Errors;
using SystemITI.API.Migrations;
using SystemITI.API.persistence.context;
using SystemITI.API.Services.ServicesAbstracts;

namespace SystemITI.API.Core.Featuer.Authentication.Command.Handler
{
    public class AuthenticationCommandHandler(UserManager<User> userManager, IJwtProvider jwtProvider, ApplicationDbContext context,IMapper mapper) :
                                                                                                                                      IRequestHandler<SigninCommandRequest, Result<SigninResponse>>,
                                                                                                                                      IRequestHandler<AddStudentCommandRequest,Result<string>>
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly IJwtProvider _jwtProvider = jwtProvider;
        private readonly ApplicationDbContext _context = context;
        private readonly IMapper _mapper = mapper;
        private readonly int _refreshTokenExpriyDays = 14;
        public async Task<Result<SigninResponse>> Handle(SigninCommandRequest request, CancellationToken cancellationToken)
        {
            //check if email is found
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                return Result.Failure<SigninResponse>(AuthenticationErrors.InvalidCredentials);
            //check if password is correct
            var IsValidPassword = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!IsValidPassword)
                return Result.Failure<SigninResponse>(AuthenticationErrors.InvalidCredentials);
            var (userRoles, userPermissions) = await GetRolesAndPermissions(user, cancellationToken);
            var (token, expiresIn) = _jwtProvider.GenerateToken(user, userRoles, userPermissions);
            var response = await GetSigninResponse(user, _refreshTokenExpriyDays, token, expiresIn);
            // return success result
            return Result.Success(response);
        }
        private static string GenerateRefreshToken()
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
        }

        public async Task<SigninResponse> GetSigninResponse(User user, int Days, string token, int expiresIn)
        {
            var resfreshToken = GenerateRefreshToken();
            // mapping to response
            var response = new SigninResponse
            {
                Id = user.Id,
                Email = user.Email!,
                UserName = user.UserName!,
                FName = user.FName,
                LName = user.LName,
                Token = token,
                ExpiresIn = expiresIn,
                RefreshToken = resfreshToken,
                RefreshTokenExpiration = DateTime.UtcNow.AddDays(Days)
            };
            user.refreshTokens.Add(new Entity.RefreshToken
            {
                Token = resfreshToken,
                ExpiresOn = response.RefreshTokenExpiration
            });
            await _userManager.UpdateAsync(user);
            return response;
        }
        private async Task<(IEnumerable<string> roles, IEnumerable<string> permissions)> GetRolesAndPermissions(User user, CancellationToken cancellationToken)
        {
            var userRoles = await _userManager.GetRolesAsync(user);
            var userPermissions = await (from r in _context.Roles
                                         join p in _context.RoleClaims
                                         on r.Id equals p.RoleId
                                         where userRoles.Contains(r.Name!)
                                         select p.ClaimValue!)
                                     .Distinct()
                                     .ToListAsync(cancellationToken);
            return (userRoles, userPermissions);
        }

        public async Task<Result<string>> Handle(AddStudentCommandRequest request, CancellationToken cancellationToken)
        {
            //check if email is found
            var emailIsExist = await _userManager.FindByEmailAsync(request.Email);
            if (emailIsExist!=null)
                return Result.Failure<string>(AuthenticationErrors.EmailAlreadyExists);
            //check if user name is exist
            var userNameIsExist= await _userManager.FindByNameAsync(request.UserName);
            if (userNameIsExist != null)
                return Result.Failure<string>(AuthenticationErrors.UsernameAlreadyExists);
            var user = _mapper.Map<User>(request);
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Student");
                return Result.Success($"User '{user.UserName}' created successfully.");

            }
            return Result.Failure<string>(new Error(result.Errors.First().Code, result.Errors.First().Description, StatusCodes.Status409Conflict));
        }
    }
}
