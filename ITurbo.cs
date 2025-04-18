using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    interface ITurbo
    {
        void TurnOnTurbo();
        void TurnOffTurbo();
        bool IsTurboOn { get; }
    }

    
    interface IEco
    {
        void EnableEcoMode();
        void DisableEcoMode();
        bool IsEcoModeEnabled { get; }
    }
}
