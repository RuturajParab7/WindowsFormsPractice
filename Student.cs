using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApplication
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }

        public void EvaluateGrade()
        {
            if (Marks >= 90)
                Grade = "A";
            else if (Marks >= 75)
                Grade = "B";
            else if (Marks >= 60)
                Grade = "C";
            else if (Marks >= 40)
                Grade = "D";
            else
                Grade = "F";
        }
    }
}
