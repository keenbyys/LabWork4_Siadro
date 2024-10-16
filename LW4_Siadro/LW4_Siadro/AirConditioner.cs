﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LW4_Siadro
{
    class AirConditioner : ClimateDevice
    {
        public AirConditioner()
            : base()
        {
            Temperature = 10;
            Duration = 60;
        }

        public AirConditioner(int temperature, double duration)
        {
            Temperature = temperature;
            Duration = duration;
        }

        public override void TurnOn()
        {
            Console.WriteLine("\n The air conditioner cools the room ({0} degrees Celsius)." +
                "\n The air conditioner will run for {1} minutes.", Temperature, Duration);
        }

        public override void SetUp()
        {
            Console.WriteLine("\n The air conditioner's default data is set, but the cooling process has not started." +
                "\n If you want to fully run the process, you need to go to \"Turn on\" --> \"Set manually\"");
        }

        public override void String()
        {
            Console.WriteLine("\n Temperature = {0} degrees Celsius." +
                "\n Duration = {1} min.", Temperature, Duration);
        }
    }
}
