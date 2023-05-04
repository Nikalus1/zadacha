using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Triangle:Shape
    {
        private double perimeter { get; set; }
        private double area { get; set; }

        public Triangle(double perimeter, double area,string figureName,double side):base(figureName,side)
        {
            this.perimeter = perimeter;
            this.area = area;
        }
        public override double FindP()
        {
            return side + side + side;
        }
        public override double FindS()
        {
            return side * side / side;
        }
    }
}
