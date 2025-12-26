using FluentValidation;
using SystemITI.API.Core.Featuer.Authentication.Command.Models;

namespace SystemITI.API.Core.Featuer.Authentication.Command.Validation
{
    public class AddStudentCommandRequestValidator:AbstractValidator<AddStudentCommandRequest>
    {
        public AddStudentCommandRequestValidator() {

            RuleFor(x => x.Email)
               .NotEmpty().WithMessage("Email is required.")
               .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.Password)
               .NotEmpty().WithMessage("Password is required.")
               .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
               .Matches("[A-Z]").WithMessage("Password must contain at least one uppercase letter.")
               .Matches("[a-z]").WithMessage("Password must contain at least one lowercase letter.")
               .Matches("[0-9]").WithMessage("Password must contain at least one number.");

            RuleFor(x => x.UserName)
               .NotEmpty().WithMessage("Username is required.")
               .MinimumLength(3).WithMessage("Username must be at least 3 characters long.");

            RuleFor(x => x.FName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(50).WithMessage("First name cannot exceed 50 characters.");

            RuleFor(x => x.LName)
               .NotEmpty().WithMessage("Last name is required.")
               .MaximumLength(50).WithMessage("Last name cannot exceed 50 characters.");



        }
    }
}
