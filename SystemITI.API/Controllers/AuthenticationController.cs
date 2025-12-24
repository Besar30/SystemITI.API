using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Api.Const;
using SystemITI.API.Core.Featuer.Authentication.Command.Models;

namespace SystemITI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController (IMediator mediator): ControllerBase
    {
        private readonly IMediator _mediator= mediator;
        [HttpPost("Sign-In")]
        public async Task<IActionResult> SignInAsync([FromBody] SigninCommandRequest command)
        {
            var result = await _mediator.Send(command);
            return result.IsSuccess ? Ok(result) : result.ToProblem();
        }
    }
}
