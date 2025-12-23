using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity;

namespace SystemITI.API.Core.Featuer.Exams.Query.Models
{
    public class GetAllExamRequestQuery:IRequest<Result<List<Exam>>>
    {
    }
}
