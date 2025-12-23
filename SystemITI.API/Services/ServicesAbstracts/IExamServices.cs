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
    }
}
