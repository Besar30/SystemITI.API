using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemITI.API.Entity
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        [Column("exam_id")]
        public int ExamId { get; set; }

        [Column("exam_date")]
        public DateTime ExamDate { get; set; }

        [Column("exam_duration")]
        public int ExamDuration { get; set; }

        [Column("crs_id")]
        public int? CourseId { get; set; } // لأنه بيقبل null
    }
}