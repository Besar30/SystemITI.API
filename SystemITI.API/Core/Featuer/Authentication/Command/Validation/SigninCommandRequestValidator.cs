using FluentValidation;
using SystemITI.API.Core.Featuer.Authentication.Command.Models;

namespace SystemITI.API.Core.Featuer.Authentication.Command.Validation
{
    public class SigninCommandRequestValidator:AbstractValidator<SigninCommandRequest>
    {
        public SigninCommandRequestValidator() {
            RuleFor(x => x.Email).NotNull()
                .NotEmpty()
                .EmailAddress();
            RuleFor(x=>x.Password).NotNull()
                .NotEmpty();
        }
    }
}
