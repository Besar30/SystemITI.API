using Microsoft.EntityFrameworkCore;

namespace SystemITI.API.Entity.Procedures
{
    [Keyless]
    public class getModelAnswerExam:getexam
    {
        public string Answer { get; set; }
    }
    public class getModelAnswerExamParameters
    {
        public int examid { get; set; }
    }
}
