using SystemITI.API.Core.Featuer.Exam.Command.Models;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Mapping.Exam
{
    public partial class ExamProfile
    {
        void GenerteExamCommandMapping()
        {
            CreateMap<GenerateExamCommandRequest, generateExamParameters>();
        }
    }
}
