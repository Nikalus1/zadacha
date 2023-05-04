using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Shape
    {
        protected Shape(string figureName,double side) 
        {
            this.figureName = figureName;
            this.side=side;
        }
        public string figureName { get; set; }
        public double side { get; set; }

        public abstract double FindP();
        public abstract double FindS();
    }
}
