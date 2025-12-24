using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolProject.Infrastructure.Abstracts.Const;
using SystemITI.API.Entity;

namespace SystemITI.API.persistence.Configration
{
    public class UserConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.OwnsMany(x => x.refreshTokens)
                .WithOwner()
                .HasForeignKey("UserId");

            //Default data
            builder.HasData(
                    new User
                    {
                        Id = DefaultUsers.AdminId,
                        FName = "SystemITI",
                        LName = "Admin",
                        UserName = DefaultUsers.AdminUserName,
                        NormalizedUserName = DefaultUsers.AdminEmail.ToUpper(),
                        Email = DefaultUsers.AdminEmail,
                        NormalizedEmail = DefaultUsers.AdminEmail.ToUpper(),
                        SecurityStamp = DefaultUsers.AdminSecurityStamp,
                        ConcurrencyStamp = DefaultUsers.AdminConcurrencyStamp,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        PhoneNumber = "01205024661",
                        PasswordHash = "AQAAAAIAAYagAAAAEES76XCzEAJzOKK3RHphtyNuJc52FtrqMqoDuSoo921MiNJ/llOGYPXIq92thIuxvg=="

                    });
        }

    }
}
