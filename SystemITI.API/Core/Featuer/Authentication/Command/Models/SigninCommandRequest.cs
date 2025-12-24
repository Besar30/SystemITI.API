using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Core.Featuer.Authentication.Command.Results;

namespace SystemITI.API.Core.Featuer.Authentication.Command.Models
{
    public class SigninCommandRequest:IRequest<Result<SigninResponse>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
