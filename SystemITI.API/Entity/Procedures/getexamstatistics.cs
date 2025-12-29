namespace SystemITI.API.Entity.Procedures
{
    public class getexamstatistics
    {
        public int total_students { get; set; }
        public int average {  get; set; }
        public int highest {  get; set; }
        public int lowest { get; set; }
    }
    public class getexamstatisticssParameters
    {
        public int exam_id { get; set; }
    }
}
