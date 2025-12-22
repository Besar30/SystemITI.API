using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.Infrastructure.Abstracts.Procedures
{
    public interface IgetexamProcRepository
    {
        public Task<IReadOnlyList<getexam>> Getexam(getexamParameters parameters);
    }
}
