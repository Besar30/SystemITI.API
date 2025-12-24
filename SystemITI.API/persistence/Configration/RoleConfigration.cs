using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SystemITI.API.Entity;
using SystemITI.API.Infrastructure.Abstracts.Const;

namespace SystemITI.API.persistence.Configration
{
    public class RoleConfigration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData([
               new ApplicationRole
                {
                    Id = DefaultRoles.AdminRoleId,
                    Name = DefaultRoles.Admin,
                    NormalizedName = DefaultRoles.Admin.ToUpper(),
                    ConcurrencyStamp = DefaultRoles.AdminRoleConcurrencyStamp
                },
                new ApplicationRole
                {
                    Id = DefaultRoles.StudentRoleId,
                    Name = DefaultRoles.Student,
                    NormalizedName = DefaultRoles.Student.ToUpper(),
                    ConcurrencyStamp = DefaultRoles.StudentRoleConcurrencyStamp,
                    IsDefualt = true // تعيين دور الافتراضي للمستخدم العادي
                },
                new ApplicationRole{
                    Id=DefaultRoles.InstructorRoleId,
                    Name=DefaultRoles.Instructor,
                    NormalizedName=DefaultRoles.Instructor.ToUpper(),
                    ConcurrencyStamp=DefaultRoles.InstructorRoleConcurrencyStamp,
                    IsDefualt = true
                }
           ])

                ;

        }
    }
}
