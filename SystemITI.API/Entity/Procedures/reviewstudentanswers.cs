using Microsoft.EntityFrameworkCore;

namespace SystemITI.API.Entity.Procedures
{
    [Keyless]
    public class reviewstudentanswers
    {
        public int q_id {  get; set; }
        public string q_text { get; set; }
        public string std_choice { get; set; }
        public string q_answer { get; set; }
        public bool is_correct { get; set; }
    }
    public class reviewstudentanswersParameters
    {
        public int exam_id { get; set; }
        public int std_id { get; set; }
    }
}
