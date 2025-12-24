using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolProject.Infrastructure.Abstracts.Const;
using SystemITI.API.Infrastructure.Abstracts.Const;

namespace SystemITI.API.persistence.Configration
{
    public class UserRolesConfigration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                 new IdentityUserRole<string>
                 {
                     UserId = DefaultUsers.AdminId,
                     RoleId = DefaultRoles.AdminRoleId
                 }
                );
        }
    }
}
