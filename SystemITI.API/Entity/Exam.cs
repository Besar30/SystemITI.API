using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemITI.API.Entity
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        public int exam_id { get; set; }
        public DateTime exam_date { get; set; }
        public int exam_duration { get; set; }
    }
}
