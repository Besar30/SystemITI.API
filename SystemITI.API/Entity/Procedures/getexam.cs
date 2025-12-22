using Microsoft.EntityFrameworkCore;

namespace SystemITI.API.Entity.Procedures
{

    [Keyless]
    public class getexam
    {
        public int q_id { get; set; }
        public string q_text { get; set; }
        public string? Choice1 { get; set; }
        public string? Choice2 { get; set; }
        public string? Choice3 { get; set; }
        public string? Choice4 { get; set; }
    }


    public class getexamParameters
    {
        public int examid { get; set; }
    }
}
