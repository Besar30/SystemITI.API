using AutoMapper;

namespace SystemITI.API.Core.Mapping.ExamMapping
{
    public partial class ExamProfile:Profile
    {
        public ExamProfile() {

            GenerteExamCommandMapping();
            getModelAnswerExamPramRequestMapping();
            InsertStudentAnswerCommandMapping();
        }
    }
}
