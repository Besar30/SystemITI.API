using FluentValidation;
using SystemITI.API.Core.Featuer.Exams.Query.Models;

namespace SystemITI.API.Core.Featuer.Exams.Query.Validator
{
    public class getexamstatisticsRequestQueryValidator:AbstractValidator<getexamstatisticsRequestQuery>
    {
        public getexamstatisticsRequestQueryValidator() {

            RuleFor(x=>x.exam_id).NotNull().NotEmpty();
        }
    }
}
