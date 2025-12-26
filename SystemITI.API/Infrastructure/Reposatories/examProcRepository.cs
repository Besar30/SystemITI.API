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
                 .ExecuteSqlInterpolatedAsync($"EXEC dbo.generateExam @Crsid={parameters.Crs_id} , @mcqNumber={parameters.mcqNumber}, @tfNumber={parameters.tfNumber}");
                
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

        public async Task<insertstudentanswer> insertstudentanswer(insertstudentanswerParameters parameters)
        {
            var result =await  _context.
                insertstudentanswers.
                FromSqlInterpolated($"EXEC dbo.insertstudentanswer @exam_id={parameters.exam_id} , @std_id={parameters.std_id} , @q_id={parameters.q_id} , @std_choice={parameters.std_choice}")
                .ToListAsync();  
            return result.First();
        }

        public async Task<bool> StudentIsExist(int Id)
        {
            return await _context.Students.AnyAsync(x=>x.std_id == Id);
        }
    }
}
