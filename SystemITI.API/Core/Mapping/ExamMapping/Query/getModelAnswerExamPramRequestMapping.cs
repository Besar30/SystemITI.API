using SystemITI.API.Core.Featuer.Exams.Query.Models;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Core.Mapping.ExamMapping
{
    public partial class ExamProfile
    {
        void getModelAnswerExamPramRequestMapping()
        {
            CreateMap<getModelAnswerExamRequestQuery, getModelAnswerExamParameters>();
        }
    }
}
