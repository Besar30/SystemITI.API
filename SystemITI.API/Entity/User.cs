using Microsoft.AspNetCore.Identity;

namespace SystemITI.API.Entity
{
    public class User : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public virtual List<RefreshToken> refreshTokens { get; set; } = [];

    }
}
