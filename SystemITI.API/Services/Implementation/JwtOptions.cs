using System.ComponentModel.DataAnnotations;

namespace SystemITI.API.Services.Implementation
{
    public class JwtOptions
    {
        public static string NameSection = "Jwt";
        [Required]
        public string Key { get; init; } = string.Empty;
        [Required]
        public string Issuer { get; init; } = string.Empty;
        [Required]
        public string Audience { get; init; } = string.Empty;
        [Range(1, int.MaxValue)]
        public int ExpiresIn { get; init; }
    }
}
