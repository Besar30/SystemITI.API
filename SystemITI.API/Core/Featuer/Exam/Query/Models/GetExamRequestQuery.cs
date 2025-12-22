using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Featuer.Exam.Query.Models
{
    public class GetExamRequestQuery:IRequest<Result<List<getexam>>>
    {
        public int Id { get; set; }
        public GetExamRequestQuery(int id)
        {
            Id=id;
        }
    }
}
