using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;
using SystemITI.API.Entity;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.persistence.context
{
    public class ApplicationDbContext:IdentityDbContext<User,ApplicationRole, string>
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
            builder.Entity<Exam>().ToTable("Exam", t => t.ExcludeFromMigrations());
            builder.Entity<getexam>().HasNoKey().ToView(null);

            builder.Entity<getModelAnswerExam>().HasNoKey().ToView(null);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
