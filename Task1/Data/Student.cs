namespace Task1.Data
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public float Gpa { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }


    }
}
