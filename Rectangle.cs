using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApplication
{
    public class Rectangle
    {
        private double length;
        private double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 5.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public string DisplayDetails()
        {
            return $"Length: {length}\nWidth: {width} \nArea: {GetArea()}";
        }
    }
}
