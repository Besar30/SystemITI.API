using FluentValidation;
using SystemITI.API.Core.Featuer.Exams.Query.Models;

namespace SystemITI.API.Core.Featuer.Exams.Query.Validator
{
    public class GetStudentGradeRequestQueryValidator:AbstractValidator<GetStudentGradeRequestQuery>
    {
        public GetStudentGradeRequestQueryValidator() {

            RuleFor(x => x.exam_id).NotNull().NotEmpty();
            RuleFor(x => x.std_id).NotNull().NotEmpty();
        }
    }
}
