using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Featuer.Exams.Query.Models
{
    public class getexamstatisticsRequestQuery:IRequest<Result<getexamstatistics>>
    {
        public int exam_id { get; set; }
    }
}
