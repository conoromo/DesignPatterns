using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Square : IShape
    {
        double length;

        public Square(double x)
        {
            length = x;
        }

        public double CalcArea()
        {
            return Math.Pow(length,2);
        }

        public string Print()
        {
            return $"Area of {this.GetType().Name} is {CalcArea()}";
        }
    }
}
