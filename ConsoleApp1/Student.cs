using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " ";

        }
    }
    public class StubjectClass
    {
        public string name { get; set; }
        public int MathMarks { get; set; }

        public override string ToString()
        {
            return name + " " + MathMarks + " ";

        }

    }

   public class Students
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public static void studentMethod()
        {
            List<Students> Objstudent = new List<Students>()
        {
          new Students() { StudentId = 1, Name = "Suresh", Marks = 500 },
          new Students() { StudentId = 2, Name = "Rohini", Marks = 300 },
          new Students() { StudentId = 3, Name = "Madhav", Marks = 400 },
          new Students() { StudentId = 4, Name = "Sateesh", Marks = 550 },
          new Students() { StudentId = 5, Name = "Praveen", Marks = 600 },
          new Students() { StudentId = 6, Name = "Sudheer", Marks = 700 },
          new Students() { StudentId = 7, Name = "Prasad", Marks = 550 }
        };
            var resultw = from s in Objstudent
                          select new { SName = s.Name, SID = s.StudentId, SMarks = s.Marks };
            foreach (var item in resultw)
            {
                Console.WriteLine("The StudentName is {0} ID is {1} Marks is {2}", item.SName, item.SID, item.SMarks);
            }
        }
    }


}


