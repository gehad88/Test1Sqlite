using System.Collections.Generic;

namespace Task1.Data
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
