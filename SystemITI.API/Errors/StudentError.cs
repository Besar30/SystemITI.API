using SchoolProject.Shared.Absractions;

namespace SystemITI.API.Errors
{
    public class StudentError
    {
        public static readonly Error StudentIsNotFound = new Error("Student is Not Found", "Student.StudentIsNotFound", StatusCodes.Status404NotFound);
    }
}
