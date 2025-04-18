using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Triangle : IShape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public double Area()
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }

    }
}
