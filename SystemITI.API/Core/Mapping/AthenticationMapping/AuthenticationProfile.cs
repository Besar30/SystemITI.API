using AutoMapper;

namespace SystemITI.API.Core.Mapping.AthenticationMapping
{
    public partial class AuthenticationProfile:Profile
    {
        public AuthenticationProfile() {

            AddStudentCommandMapping();
        }
    }
}
