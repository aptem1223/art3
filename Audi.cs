using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Audi : Avto, ITurbo, IEco
    {
        public bool IsTurboOn { get; private set; }
        public bool IsEcoModeEnabled { get; private set; }

        public Audi(string model, int enginePower, double fuelConsumption) : base(model, enginePower, fuelConsumption)
        {
            IsTurboOn = false;
            IsEcoModeEnabled = false;
        }

        public void TurnOnTurbo()
        {
            IsTurboOn = true;
            Console.WriteLine($"{Model}: Турбонаддув включен.");
        }

        public void TurnOffTurbo()
        {
            IsTurboOn = false;
            Console.WriteLine($"{Model}: Турбонаддув выключен.");
        }

        public void EnableEcoMode()
        {
            IsEcoModeEnabled = true;
            Console.WriteLine($"{Model}: Экономичный режим включен.");
        }

        public void DisableEcoMode()
        {
            IsEcoModeEnabled = false;
            Console.WriteLine($"{Model}: Экономичный режим выключен.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Мощность двигателя: {EnginePower} л.с.");
            Console.WriteLine($"Расход топлива: {FuelConsumption} л/100км");
            Console.WriteLine($"Турбо: {(IsTurboOn ? "Включен" : "Выключен")}");
            Console.WriteLine($"Эко режим: {(IsEcoModeEnabled ? "Включен" : "Выключен")}");
            Console.WriteLine();
        }
    }

}
