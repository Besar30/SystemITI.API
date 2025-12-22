using AutoMapper;

namespace SystemITI.API.Core.Mapping.Exam
{
    public partial class ExamProfile:Profile
    {
        public ExamProfile() {

            GenerteExamCommandMapping();
        }
    }
}
