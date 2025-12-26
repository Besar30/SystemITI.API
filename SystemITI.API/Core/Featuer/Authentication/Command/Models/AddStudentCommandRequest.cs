using MediatR;
using SchoolProject.Shared.Absractions;

namespace SystemITI.API.Core.Featuer.Authentication.Command.Models
{
    public class AddStudentCommandRequest:IRequest<Result<string>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
