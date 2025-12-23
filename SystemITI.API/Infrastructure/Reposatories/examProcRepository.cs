using Microsoft.EntityFrameworkCore;
using StoredProcedureEFCore;
using SystemITI.API.Entity;
using SystemITI.API.Entity.Procedures;
using SystemITI.API.Infrastructure.Abstracts.Procedures;
using SystemITI.API.persistence.context;

namespace SystemITI.API.Infrastructure.Reposatories
{
    public class examProcRepository(ApplicationDbContext context) : IexamProcRepository

    {
        private readonly ApplicationDbContext _context = context;
        public async Task<IReadOnlyList<getexam>> Getexam(getexamParameters parameters)
        {
            var result = await _context.getexamResults
                .FromSqlInterpolated($"EXEC dbo.getexam @examid = {parameters.examid}")
                .ToListAsync();
            return result;

        }
        public async Task GenertateExam(generateExamParameters parameters)
        {
           await  _context.Database
                 .ExecuteSqlInterpolatedAsync($"EXEC dbo.generateExam @Crs_id={parameters.Crs_id} , @mcqNumber={parameters.mcqNumber}, @tfNumber={parameters.tfNumber}");
                
        }

        public async Task<bool> CheckExamIsExist(int Id)
        {
            return await _context.Exams.AnyAsync(x=>x.ExamId == Id);
        }

        public async Task<List<Exam>> GetAllExams()
        {
            return await _context.Exams.ToListAsync();
        }

        public async Task<IReadOnlyList<getModelAnswerExam>> getModelAnswerExam(getModelAnswerExamParameters parameters)
        {
            var result = await _context.getModelAnswerExam
                                       .FromSqlInterpolated($"EXEC dbo.getModelAnswerExam @examid={parameters.examid}")
                                       .ToListAsync();
            return result;
        }
    }
}
