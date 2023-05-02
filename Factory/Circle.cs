using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class Circle : IShape
    {
        double radius;

        public Circle(double x)
        {
            radius = x;
        }

        public double CalcArea()
        {
            return Math.PI*Math.Pow(radius,2);
        }

        public string Print()
        {
            return $"Area of {this.GetType().Name} is {CalcArea()}";
        }
    }
}
