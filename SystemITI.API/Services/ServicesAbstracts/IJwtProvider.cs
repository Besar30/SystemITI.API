using SystemITI.API.Entity;
using SystemITI.API.Migrations;

namespace SystemITI.API.Services.ServicesAbstracts
{
    public interface IJwtProvider
    {
        (string Token, int ExpiresIn) GenerateToken(User user, IEnumerable<string> roles, IEnumerable<string> permissions);
        string? ValidateToken(string token);
    }
}
