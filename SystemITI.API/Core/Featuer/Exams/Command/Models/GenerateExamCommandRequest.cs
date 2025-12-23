using MediatR;
using SchoolProject.Shared.Absractions;

namespace SystemITI.API.Core.Featuer.Exams.Command.Models
{
    public class GenerateExamCommandRequest:IRequest<Result<string>>
    {
        public int Crs_id { get; set; }
        public int mcqNumber { get; set; }
        public int tfNumber { get; set; }
    }
}
