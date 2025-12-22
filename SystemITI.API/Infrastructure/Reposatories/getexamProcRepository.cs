using Microsoft.EntityFrameworkCore;
using StoredProcedureEFCore;
using SystemITI.API.Entity.Procedures;
using SystemITI.API.Infrastructure.Abstracts.Procedures;
using SystemITI.API.persistence.context;

namespace SystemITI.API.Infrastructure.Reposatories
{
    public class getexamProcRepository(ApplicationDbContext context) : IgetexamProcRepository

    {
        private readonly ApplicationDbContext _context = context;

        public async Task<IReadOnlyList<getexam>> Getexam(getexamParameters parameters)
        {
            var result = await _context.getexamResults
                .FromSqlInterpolated($"EXEC dbo.getexam @examid = {parameters.examid}")
                .ToListAsync();

            return result;

        }
    }
}
