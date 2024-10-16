using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_Siadro
{
    class Heater : ClimateDevice
    {
        public Heater()
            : base()
        {
            Temperature = 20;
            Duration = 120;
        }

        public Heater(int temperature, double duration)
        {
            Temperature = temperature;
            Duration = duration;
        }

        public override void TurnOn()
        {
            Console.WriteLine("\n The heater raises the room temperature by {0} (degrees Celsiu)." +
                "\n The heater will run for {1} minutes.", Temperature, Duration);
        }

        public override void SetUp()
        {
            Console.WriteLine("\n The default heater data is set, but the heating process has not started." +
                "\n If you want to fully run the process, you need to go to \"Turn on\" --> \"Set manually\"");
        }

        public override void String()
        {
            Console.WriteLine("\n Temperature = {0} degrees Celsius." +
                "\n Duration = {1} min.", Temperature, Duration);
        }
    }
}
