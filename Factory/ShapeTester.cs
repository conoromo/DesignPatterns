using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            double length, width, radius;
            string option;

            Console.WriteLine("Circle - C, Rectangle - R, Square - S");
            option = Console.ReadLine();

            if (option == "C")
            {
                Console.WriteLine("Enter radius:");
                radius = Convert.ToDouble(Console.ReadLine());

                Circle c = new Circle(radius);
                Console.WriteLine("Area: " + c.CalcArea());
            }
            else if (option == "R")
            {
                Console.WriteLine("Enter length:");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width:");
                width = Convert.ToDouble(Console.ReadLine());

                Rectangle r = new Rectangle(length, width);
                Console.WriteLine("Area: " + r.CalcArea());
            }
            else if (option == "S")
            {
                Console.WriteLine("Enter length:");
                length = Convert.ToDouble(Console.ReadLine());

                Square s = new Square(length);
                Console.WriteLine("Area: " + s.CalcArea());
            }
            else
            {
                Console.WriteLine("error");
            }

            
        }
    }
}
