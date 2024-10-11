using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_Siadro
{
    internal class AirConditioner : ClimateDevice
    {
        public AirConditioner() 
        { 

        }

        public AirConditioner(int temperature)
        {
            Temperature = temperature;
        }

        public override void TurnOn()
        {
            Console.WriteLine("\n The air conditioner cools the room ({0} degrees Celsius).", Temperature);
        }


    }
}
