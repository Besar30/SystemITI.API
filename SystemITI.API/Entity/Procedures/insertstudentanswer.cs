namespace SystemITI.API.Entity.Procedures
{
    public class insertstudentanswer
    {
         public bool is_correct {  get; set; }
         public string correct_answer { get; set; }
    }
    public class insertstudentanswerParameters
    {
        public int exam_id { get; set; }
        public int std_id { get; set; }
        public int q_id { get; set; }
        public string std_choice { get; set; }
    }
}
