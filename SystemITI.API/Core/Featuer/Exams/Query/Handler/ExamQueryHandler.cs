using AutoMapper;
using MediatR;
using SchoolProject.Shared.Absractions;
using SystemITI.API.Core.Featuer.Exams.Query.Models;
using SystemITI.API.Entity;
using SystemITI.API.Entity.Procedures;
using SystemITI.API.Services.ServicesAbstracts;

namespace SystemITI.API.Core.Featuer.Exams.Query.Handler
{
    public class ExamQueryHandler (IExamServices examServices ,IMapper mapper): IRequestHandler<GetExamRequestQuery, Result<List<getexam>>>,
                                                                IRequestHandler<GetAllExamRequestQuery,Result<List<Exam>>>,
                                                                IRequestHandler<getModelAnswerExamRequestQuery,Result<List<getModelAnswerExam>>>
    {
        private readonly IExamServices _examServices = examServices;
        private readonly IMapper _mapper = mapper;

        public async Task<Result<List<getexam>>> Handle(GetExamRequestQuery request, CancellationToken cancellationToken)
        {
            var parm = new getexamParameters();
            parm.examid = request.Id;
            var result = await _examServices.getExamServices(parm);
            return result.IsSuccess? Result.Success(result.Value.ToList()):Result.Failure<List<getexam>>(result.error);
        }

        public async Task<Result<List<Exam>>> Handle(GetAllExamRequestQuery request, CancellationToken cancellationToken)
        {
            var result = await _examServices.GetAllExam();
            return Result.Success(result);
        }

        public async Task<Result<List<getModelAnswerExam>>> Handle(getModelAnswerExamRequestQuery request, CancellationToken cancellationToken)
        {
            var pram = _mapper.Map<getModelAnswerExamParameters>(request);
            var result= await _examServices.getModelAnswerExam(pram);
            return result.IsSuccess ?
                Result.Success(result.Value.ToList()) : Result.Failure<List<getModelAnswerExam>>(result.error);
        }
    }
}
