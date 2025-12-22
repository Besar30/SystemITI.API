using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Api.Const;
using SystemITI.API.Core.Featuer.Exam.Query.Models;

namespace SystemITI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet("Get-Exam/{Id}")]
        public async Task<IActionResult> GetExamAsync([FromRoute] int Id)
        {
            var result= await _mediator.Send(new GetExamRequestQuery(Id));
            return result.IsSuccess ?
                Ok(result) : result.ToProblem();
        }
    }
}
