using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SystemITI.API.Entity;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.persistence.context
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public DbSet<getexam> getexamResults { get; set; }
        public DbSet<getModelAnswerExam> getModelAnswerExam {  get; set; }
        public DbSet<Exam> Exams { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Exam>().ToTable("Exam");
            builder.Entity<getexam>().HasNoKey();
            builder.Entity<getModelAnswerExam>().HasNoKey();
            base.OnModelCreating(builder);
        }
    }
}
