using Microsoft.EntityFrameworkCore;

namespace SystemITI.API.Entity
{
    [Keyless]
    public class Student
    {
        public int std_id {  get; set; }
    }
}
