using FluentValidation;
using SystemITI.API.Core.Featuer.Exams.Command.Models;

namespace SystemITI.API.Core.Featuer.Exams.Command.Validation
{
    public class InsertStudentAnswerRequestValidator:AbstractValidator<InsertStudentAnswerRequest>
    {
        public InsertStudentAnswerRequestValidator() {
            RuleFor(x => x.exam_id)
                .GreaterThan(0)
                .WithMessage("Exam ID must be greater than 0.");

            // std_id must be greater than 0
            RuleFor(x => x.std_id)
                .GreaterThan(0)
                .WithMessage("Student ID must be greater than 0.");

            // q_id must be greater than 0
            RuleFor(x => x.q_id)
                .GreaterThan(0)
                .WithMessage("Question ID must be greater than 0.");

            // std_choice must not be null or empty
            RuleFor(x => x.std_choice)
                .NotEmpty()
                .WithMessage("Student choice is required.");
               

        }
    }
}
