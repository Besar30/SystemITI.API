using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Featuer.Exams.Command.Models
{
    public class InsertStudentAnswerRequest:IRequest<Result< insertstudentanswer>>
    {
        public int exam_id { get; set; }
        public int std_id { get; set; }
        public int q_id { get; set; }
        public string std_choice { get; set; }
    }
}
