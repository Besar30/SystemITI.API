using FluentValidation;
using SystemITI.API.Core.Featuer.Exams.Query.Models;

namespace SystemITI.API.Core.Featuer.Exams.Query.Validator
{
    public class GetExamRequestQueryValidator:AbstractValidator<GetExamRequestQuery>
    {
        public GetExamRequestQueryValidator() { 
            RuleFor(x=>x.Id).NotNull().NotEmpty();
        }
    }
}
