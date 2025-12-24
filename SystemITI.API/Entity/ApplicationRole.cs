using Microsoft.AspNetCore.Identity;

namespace SystemITI.API.Entity
{
    public class ApplicationRole:IdentityRole
    {
        public bool IsDefualt { get; set; }
        public bool IsDelete { get; set; }
    }
}
