﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IShape triangle = new Triangle(3, 4, 5);  
            IShape disk = new Disk(10);              

            
            ShapePrinter.PrintShapeInfo(triangle);
            Console.WriteLine();  
            ShapePrinter.PrintShapeInfo(disk);
        }
    }
}
