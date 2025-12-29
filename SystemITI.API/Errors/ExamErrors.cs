using SchoolProject.Shared.Absractions;

namespace SystemITI.API.Errors
{
    public  class ExamErrors
    {
        public static readonly Error ExamIsNotFound = new Error("Exam is Not Found", "Exam.ExamIsNotFound",StatusCodes.Status404NotFound);
        public static readonly Error ExamStatisticsNotFound =
        new Error("No statistics available for this exam", "Exam.ExamStatisticsNotFound", StatusCodes.Status404NotFound);
    }
}
