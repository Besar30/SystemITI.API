using FluentValidation;
using SystemITI.API.Core.Featuer.Exam.Command.Models;

namespace SystemITI.API.Core.Featuer.Exam.Command.Validation
{
    public class GenerateExamCommandRequestValidator:AbstractValidator<GenerateExamCommandRequest>
    {
        public GenerateExamCommandRequestValidator() {
            RuleFor(x => x.Crs_id).NotNull().NotEmpty();
            RuleFor(x => x.mcqNumber).NotNull().NotEmpty();
            RuleFor(x => x.tfNumber).NotNull().NotEmpty();

        }
    }
}
