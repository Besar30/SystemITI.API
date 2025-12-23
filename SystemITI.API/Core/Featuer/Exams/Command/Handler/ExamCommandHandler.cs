using AutoMapper;
using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Core.Featuer.Exams.Command.Models;
using SystemITI.API.Entity.Procedures;
using SystemITI.API.Services.ServicesAbstracts;
namespace SystemITI.API.Core.Featuer.Exams.Command.Handler
{
    public class ExamCommandHandler(IMapper mapper ,IExamServices examServices) : IRequestHandler<GenerateExamCommandRequest, Result<string>>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IExamServices _examServices = examServices;

        public async Task<Result<string>> Handle(GenerateExamCommandRequest request, CancellationToken cancellationToken)
        {
            var prams = _mapper.Map<generateExamParameters>(request);
            var result = await _examServices.generateExam(prams);
            return result.IsSuccess ?
                Result.Success("Exam Generated Succsesflly") : Result.Failure<string>(result.error);
        }
    }
}
