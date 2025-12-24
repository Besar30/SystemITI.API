using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Api.Const;
using SchoolProject.Infrastructure.Abstracts.Const;
using SystemITI.API.Core.Featuer.Exams.Command.Models;
using SystemITI.API.Core.Featuer.Exams.Query.Models;
using SystemITI.API.Infrastructure.Abstracts.Const;

namespace SystemITI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ExamController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;
        [HttpGet("Get-All-Exams")]
        [Authorize(Roles = DefaultRoles.Admin)]
        public async Task<IActionResult> GetAllExamsAsync()
        {
            var result = await _mediator.Send(new GetAllExamRequestQuery());
            return result.IsSuccess ?
                Ok(result) : result.ToProblem();
        }
        [HttpGet("Get-Exam/{Id}")]
        public async Task<IActionResult> GetExamAsync([FromRoute] int Id)
        {
            var result= await _mediator.Send(new GetExamRequestQuery(Id));
            return result.IsSuccess ?
                Ok(result) : result.ToProblem();
        }
        [Authorize(Roles = DefaultRoles.Admin)]

        [HttpPost("Generate-Exam")]
        public async Task<IActionResult> GenereateExamAsync([FromBody] GenerateExamCommandRequest commad)
        {
            var result = await _mediator.Send(commad);
            return result.IsSuccess ?
                Ok(result) : result.ToProblem();
        }
        [Authorize(Roles = DefaultRoles.Admin)]

        [HttpGet("Get-Exam-Anwer-Model/{id}")]
        public async Task<IActionResult> GetExamAnswerModelAsync([FromRoute]int id)
        {
            var result= await _mediator.Send(new getModelAnswerExamRequestQuery(id));
            return result.IsSuccess ?
                Ok(result) : result.ToProblem();
        }
    }
}
