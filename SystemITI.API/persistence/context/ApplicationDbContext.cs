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
        public DbSet<Student> Students { get; set; }
        public DbSet<insertstudentanswer> insertstudentanswers { get; set; }
        public DbSet<reviewstudentanswers> reviewstudentanswers { get; set; }
        public DbSet<getexamresults> getexamresults { get; set; }
        public DbSet<getexamstatistics> getexamstatistics { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Exam>().ToTable("Exam", t => t.ExcludeFromMigrations());
            builder.Entity<Student>().ToTable("Student", t => t.ExcludeFromMigrations());
            builder.Entity<getexam>().HasNoKey().ToView(null);

            builder.Entity<getModelAnswerExam>().HasNoKey().ToView(null);
            builder.Entity<insertstudentanswer>().HasNoKey().ToView(null);
            builder.Entity<reviewstudentanswers>().HasNoKey().ToView(null);
            builder.Entity<getexamresults>().HasNoKey().ToView(null);
            builder.Entity<getexamstatistics>().HasNoKey().ToView(null);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
