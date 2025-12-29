namespace SystemITI.API.Entity.Procedures
{
    public class getexamresults
    {
        public int std_id { get; set; }
        public string fullName { get; set; }
        public string crs_name { get; set; }
        public int total_grade { get; set; }
    }
    public class getexamresultsParameters
    {
        public int exam_id { get; set; }
        public int std_id { get; set; }
    }
}
