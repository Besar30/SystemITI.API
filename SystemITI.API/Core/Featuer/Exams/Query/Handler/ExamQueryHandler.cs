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
                                                                IRequestHandler<getModelAnswerExamRequestQuery,Result<List<getModelAnswerExam>>>,
                                                                IRequestHandler<reviewstudentanswersRequestQuery,Result<List<reviewstudentanswers>>>,
                                                                IRequestHandler<GetStudentGradeRequestQuery,Result<List<getexamresults>>>,
                                                                IRequestHandler<getexamstatisticsRequestQuery,Result<getexamstatistics>>
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

        public async Task<Result<List<reviewstudentanswers>>> Handle(reviewstudentanswersRequestQuery request, CancellationToken cancellationToken)
        {
           var pram= _mapper.Map<reviewstudentanswersParameters>(request);
            var result= await _examServices.reviewstudentanswers(pram);
            return result.IsSuccess ?
                              Result.Success(result.Value):Result.Failure<List<reviewstudentanswers>>(result.error);
        }

        public async Task<Result<List<getexamresults>>> Handle(GetStudentGradeRequestQuery request, CancellationToken cancellationToken)
        {
           var param= _mapper.Map<getexamresultsParameters>(request);
            var result = await _examServices.GetGradeStudent(param);
            return result.IsSuccess ?
                          Result.Success(result.Value) : Result.Failure<List<getexamresults>>(result.error);
        }

        public async Task<Result<getexamstatistics>> Handle(getexamstatisticsRequestQuery request, CancellationToken cancellationToken)
        {
           var param=new getexamstatisticssParameters();
            param.exam_id=request.exam_id;
            var result=await _examServices.GetExamStatistics(param);
            return result.IsSuccess?
                Result.Success(result.Value) :Result.Failure<getexamstatistics>(result.error);
        }
    }
}
