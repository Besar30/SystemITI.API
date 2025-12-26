using SchoolProject.Shared.Absractions;
using System.Collections.Generic;
using SystemITI.API.Entity;
using SystemITI.API.Entity.Procedures;
using SystemITI.API.Errors;
using SystemITI.API.Infrastructure.Abstracts.Procedures;
using SystemITI.API.Services.ServicesAbstracts;

namespace SystemITI.API.Services.Implementation
{
    public class ExamServices(IexamProcRepository igetexamProcRepository) : IExamServices
    {
        private readonly IexamProcRepository _igetexamProcRepository = igetexamProcRepository;

        public async Task<Result<IReadOnlyList<getexam>>> getExamServices(getexamParameters Parameters)
        {
            var ExamIsExist = await _igetexamProcRepository.CheckExamIsExist(Parameters.examid);
            if (!ExamIsExist)
                return Result.Failure<IReadOnlyList<getexam>>(ExamErrors.ExamIsNotFound);
            var result = await _igetexamProcRepository.Getexam(Parameters);
            return Result.Success(result);
        }

        public async Task<Result> generateExam(generateExamParameters parameters)
        {
           await _igetexamProcRepository.GenertateExam(parameters);
            return Result.Success();
        }

        public async Task<List<Exam>> GetAllExam()
        {
            return await _igetexamProcRepository.GetAllExams();
        }

        public async Task<Result<IReadOnlyList<getModelAnswerExam>>> getModelAnswerExam(getModelAnswerExamParameters Parameters)
        {
           var result= await _igetexamProcRepository.getModelAnswerExam(Parameters);
            return Result.Success(result);
        }

        public async Task<Result< insertstudentanswer>> insertstudentanswer(insertstudentanswerParameters parameters)
        {
            var ExamIsExist = await _igetexamProcRepository.CheckExamIsExist(parameters.exam_id);
            if (!ExamIsExist)
                return Result.Failure<insertstudentanswer>(ExamErrors.ExamIsNotFound);
            var StudentIsExist = await _igetexamProcRepository.StudentIsExist(parameters.std_id);
            if(!StudentIsExist)
                return Result.Failure< insertstudentanswer >(StudentError.StudentIsNotFound);
           var result= await _igetexamProcRepository.insertstudentanswer(parameters);
            return Result.Success(result);
        }
    }
}
