using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Infrastructure.Abstracts.Procedures
{
    public interface IexamProcRepository
    {
        public Task<IReadOnlyList<getexam>> Getexam(getexamParameters parameters);
        public Task GenertateExam(generateExamParameters parameters);
    }
}
