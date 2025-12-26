using SystemITI.API.Entity;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Infrastructure.Abstracts.Procedures
{
    public interface IexamProcRepository
    {
        public Task<IReadOnlyList<getexam>> Getexam(getexamParameters parameters);
        public Task<IReadOnlyList<getModelAnswerExam>> getModelAnswerExam(getModelAnswerExamParameters parameters);
        public Task GenertateExam(generateExamParameters parameters);
        public Task<bool> CheckExamIsExist(int Id);
        public Task<List<Exam>> GetAllExams();
        public Task<insertstudentanswer> insertstudentanswer(insertstudentanswerParameters parameters);
        public Task<bool> StudentIsExist(int Id);
    }
}
