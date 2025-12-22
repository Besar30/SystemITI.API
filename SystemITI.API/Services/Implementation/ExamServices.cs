using SchoolProject.Shared.Absractions;
using SystemITI.API.Entity.Procedures;
using SystemITI.API.Infrastructure.Abstracts.Procedures;
using SystemITI.API.Services.ServicesAbstracts;

namespace SystemITI.API.Services.Implementation
{
    public class ExamServices(IgetexamProcRepository igetexamProcRepository) : IExamServices
    {
        private readonly IgetexamProcRepository _igetexamProcRepository = igetexamProcRepository;

        public async Task<Result<IReadOnlyList<getexam>>> getExamServices(getexamParameters Parameters)
        {
           var result= await _igetexamProcRepository.Getexam(Parameters);
            return Result.Success(result);
        }
    }
}
