using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_Siadro
{
    class AirHumidifier : ClimateDevice 
    {
        public AirHumidifier()
            : base()
        {
            Humidity = 15;
            Duration = 40;
        }

        public AirHumidifier(int humidity, double duration)
        {
            Humidity = humidity;
            Duration = duration;
        }

        public override void TurnOn()
        {
            Console.WriteLine("\n A humidifier changes the humidity in the room by {0}%." +
                "\n The air humidifier will run for {1} minutes.", Humidity, Duration);
        }

        public override void SetUp()
        {
            Console.WriteLine("\n The default humidifier data is set, but the humidification process has not started." +
                "\n If you want to fully run the process, you need to go to \"Turn on\" --> \"Set manually\"");
        }

        public override void String()
        {
            Console.WriteLine("\n Humidity = {0}%." +
                "\n Duration = {1} min.", Humidity, Duration);
        }
    }
}
