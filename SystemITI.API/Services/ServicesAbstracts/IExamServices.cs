using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Services.ServicesAbstracts
{
    public interface IExamServices
    {
        public Task<Result<IReadOnlyList<getexam>>> getExamServices(getexamParameters Parameters);
        public Task<Result<IReadOnlyList<getModelAnswerExam>>> getModelAnswerExam(getModelAnswerExamParameters Parameters);
        public Task<Result> generateExam(generateExamParameters parameters);
        public Task<List<Exam>> GetAllExam();
        public Task<Result< insertstudentanswer>> insertstudentanswer(insertstudentanswerParameters parameters);
        public Task<Result<List<reviewstudentanswers>>> reviewstudentanswers(reviewstudentanswersParameters parameters);
        public Task<Result<List<getexamresults>>> GetGradeStudent(getexamresultsParameters parameters);
        public Task<Result<getexamstatistics>> GetExamStatistics(getexamstatisticssParameters parameters);
    }
}
