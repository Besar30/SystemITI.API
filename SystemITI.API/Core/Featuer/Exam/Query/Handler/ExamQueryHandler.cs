using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Core.Featuer.Exam.Query.Models;
using SystemITI.API.Entity.Procedures;
using SystemITI.API.Services.ServicesAbstracts;

namespace SystemITI.API.Core.Featuer.Exam.Query.Handler
{
    public class ExamQueryHandler (IExamServices examServices): IRequestHandler<GetExamRequestQuery, Result<List<getexam>>>
    {
        private readonly IExamServices _examServices = examServices;

        public async Task<Result<List<getexam>>> Handle(GetExamRequestQuery request, CancellationToken cancellationToken)
        {
            var parm = new getexamParameters();
            parm.examid = request.Id;
            var result = await _examServices.getExamServices(parm);
            return Result.Success(result.Value.ToList());
        }
    }
}
