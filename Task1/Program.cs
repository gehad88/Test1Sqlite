using System;
using Task1.Data;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dataBase = new T1Context())
            {
                // dataBase.Add(new Subject() { SubjectName="NETWORK" });
                dataBase.Add(new Student() {StudentName = "Nada" , Gpa = 3,  SubjectID = 1 });
                dataBase.SaveChanges();
            }
            Console.WriteLine("DONE");
        }
    }
}
