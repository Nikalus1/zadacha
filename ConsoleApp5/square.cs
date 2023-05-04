using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class square:Shape,FigureInfo
    {
        private double perimeter { get; set; }
        private double area { get; set; }

        public square(double perimeter, double area, string figureName, double side) : base(figureName, side)
        {

        }

        public override double FindP()
        {
            return side * 4;
        }

        public override double FindS()
        {
            return side * side;
        }

        public double Print()
        {
            return FindP();
        }
    }
}
