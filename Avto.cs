using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Avto
    {
        public string Model { get; protected set; }
        public int EnginePower { get; protected set; }
        public double FuelConsumption { get; protected set; }

        public Avto(string model, int enginePower, double fuelConsumption)
        {
            Model = model;
            EnginePower = enginePower;
            FuelConsumption = fuelConsumption;
        }

        public abstract void DisplayInfo();
    }
}
