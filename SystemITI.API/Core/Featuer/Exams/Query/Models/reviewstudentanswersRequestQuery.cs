using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Featuer.Exams.Query.Models
{
    public class reviewstudentanswersRequestQuery:IRequest<Result<List<reviewstudentanswers>>>
    {
        public int exam_id { get; set; }
        public int std_id { get; set; }
    }
}
