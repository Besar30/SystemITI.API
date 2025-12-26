using SystemITI.API.Core.Featuer.Authentication.Command.Models;
using SystemITI.API.Entity;

namespace SystemITI.API.Core.Mapping.AthenticationMapping
{
    public partial class AuthenticationProfile
    {
        void AddStudentCommandMapping()
        {
            CreateMap<AddStudentCommandRequest, User>();
        }
    }
}
