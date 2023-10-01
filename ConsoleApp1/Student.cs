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
   

    }


