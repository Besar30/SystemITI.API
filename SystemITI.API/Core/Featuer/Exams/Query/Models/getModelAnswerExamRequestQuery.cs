using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Featuer.Exams.Query.Models
{
    public class getModelAnswerExamRequestQuery:IRequest<Result<List<getModelAnswerExam>>>
    {
        public int examid { get; set; }
        public getModelAnswerExamRequestQuery(int id)
        {
            examid = id;
        }
    }
}
