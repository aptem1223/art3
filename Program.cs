using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audiA4 = new Audi("Audi A4", 190, 6.5);
            BMW bmwX5 = new BMW("BMW X5", 340, 9.0);
            Audi audiRS6 = new Audi("Audi RS6", 600, 12.0);

            audiA4.DisplayInfo();
            audiA4.TurnOnTurbo();
            audiA4.EnableEcoMode();
            audiA4.DisplayInfo();
            audiA4.TurnOffTurbo();
            audiA4.DisableEcoMode();
            audiA4.DisplayInfo();

            bmwX5.DisplayInfo();
            bmwX5.TurnOnTurbo();
            bmwX5.DisplayInfo();
            bmwX5.DisableEcoMode();
            bmwX5.DisplayInfo();

            audiRS6.DisplayInfo();
            audiRS6.TurnOnTurbo();
            audiRS6.DisplayInfo();
        }
    }
}
