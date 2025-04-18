using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class BMW : Avto, ITurbo, IEco
    {
        public bool IsTurboOn { get; private set; }
        public bool IsEcoModeEnabled { get; private set; }

        public BMW(string model, int enginePower, double fuelConsumption) : base(model, enginePower, fuelConsumption)
        {
            IsTurboOn = false;
            IsEcoModeEnabled = false;
        }

        public void TurnOnTurbo()
        {
            IsTurboOn = true;
            Console.WriteLine($"{Model}: Турбонаддув активирован.");
        }

        public void TurnOffTurbo()
        {
            IsTurboOn = false;
            Console.WriteLine($"{Model}: Турбонаддув деактивирован.");
        }

        public void EnableEcoMode()
        {
            IsEcoModeEnabled = true;
            Console.WriteLine($"{Model}: Режим Eco Pro активирован.");
        }

        public void DisableEcoMode()
        {
            IsEcoModeEnabled = false;
            Console.WriteLine($"{Model}: Режим Eco Pro деактивирован.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Мощность: {EnginePower} кВт");
            Console.WriteLine($"Потребление топлива: {FuelConsumption} л/100 км");
            Console.WriteLine($"Турбонаддув: {(IsTurboOn ? "+" : "-")}");
            Console.WriteLine($"Eco режим: {(IsEcoModeEnabled ? "Да" : "Нет")}");
            Console.WriteLine();
        }
    }
}

