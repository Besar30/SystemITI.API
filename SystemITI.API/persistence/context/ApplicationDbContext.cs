using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using SystemITI.API.Entity.Procedures;

namespace SystemITI.API.persistence.context
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public DbSet<getexam> getexamResults { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<getexam>().HasNoKey();

            base.OnModelCreating(builder);
        }
    }
}
