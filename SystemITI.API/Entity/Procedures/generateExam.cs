using Microsoft.EntityFrameworkCore;

namespace SystemITI.API.Entity.Procedures
{
    [Keyless]
    public class generateExam
    {
    }
    public class generateExamParameters
    {
        public int Crs_id {  get; set; }
        public int mcqNumber { get; set; }
        public int tfNumber { get; set; }
    }
}
