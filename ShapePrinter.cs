using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ShapePrinter
    {
        public static void PrintShapeInfo(IShape shape)
        {
            if (shape is Triangle triangle)
            {
                Console.WriteLine("Фигура: Треугольник");
                Console.WriteLine($"Стороны: {triangle.Side1}, {triangle.Side2}, {triangle.Side3}");
                Console.WriteLine($"Периметр: {triangle.Perimeter()}");
                Console.WriteLine($"Площадь: {triangle.Area()}");
            }
            else if (shape is Disk disk)
            {
                Console.WriteLine("Фигура: Круг");
                Console.WriteLine($"Радиус: {disk.Radius}");
                Console.WriteLine($"Периметр: {disk.Perimeter()}");
                Console.WriteLine($"Площадь: {disk.Area()}");
            }
            else
            {
                Console.WriteLine("Неизвестная фигура");
            }
        }
        
    }
}
