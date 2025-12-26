using SchoolProject.Shared.Absractions;

namespace SystemITI.API.Errors
{
    public class AuthenticationErrors
    {
        public static readonly Error InvalidCredentials =
     new Error("InvalidCredentials", "Authentication.InvalidCredentials", StatusCodes.Status401Unauthorized);
        public static readonly Error EmailAlreadyExists =
    new Error("EmailAlreadyExists", "Authentication.EmailAlreadyExists", StatusCodes.Status409Conflict);
        public static readonly Error UsernameAlreadyExists =
    new Error("UsernameAlreadyExists", "Authentication.UsernameAlreadyExists", StatusCodes.Status409Conflict);
    }
}
