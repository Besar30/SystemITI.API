using SchoolProject.Shared.Absractions;

namespace SystemITI.API.Errors
{
    public  class ExamErrors
    {
        public static readonly Error ExamIsNotFound = new Error("Exam is Not Found", "Exam.ExamIsNotFound",StatusCodes.Status404NotFound);
    }
}
