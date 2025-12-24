namespace SystemITI.API.Infrastructure.Abstracts.Const
{
    public class Permissions
    {
        public static string Type { get; } = "permissions";
        public const string GetExam = "Exam:Get";
        public const string GenerateExam = "Exam:Generate";
        public const string GetExamModelAnser = "Exam:GetModelAnser";
        public const string GetStudentAnswer = "Exam:GetStudentAnswer";

        public static IList<string?> GetAllPermissions() =>
           typeof(Permissions)
               .GetFields()
               .Where(f => f.IsLiteral && !f.IsInitOnly)
               .Select(x => x.GetValue(null) as string)
               .ToList();
    }
}
