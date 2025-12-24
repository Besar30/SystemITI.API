using SchoolProject.Shared.Absractions;

namespace SystemITI.API.Errors
{
    public class AuthenticationErrors
    {
        public static readonly Error InvalidCredentials =
     new Error("InvalidCredentials", "Authentication.InvalidCredentials", StatusCodes.Status401Unauthorized);
    }
}
