using SystemITI.API.Core.Featuer.Exams.Command.Models;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Mapping.ExamMapping
{
    public partial class ExamProfile
    {
        void InsertStudentAnswerCommandMapping()
        {
            CreateMap<InsertStudentAnswerRequest,insertstudentanswerParameters>();
        }
    }
}
