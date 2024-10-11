using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LW4_Siadro
{
    internal class ClimateDevice
    {
        private double temperature;
        private int humidity;
        private int duration;

        public double Temperature
        {
            get { return temperature; } 
            set { if (value >= 10 && value <= 40)
                    temperature = value;
            }
        }

        public int Humidity
        {
            get { return humidity; }
            set { if (value >= 20 && value <= 80)
                        humidity = value;
            }
        }

        public int Duration
        {
            get { return duration; }
            set { if (value > 0)
                duration = value; }
        }

        public ClimateDevice()
        {
            Temperature = 10;
            Humidity = 30;
        }

        public ClimateDevice(double temperature, int humidity, int duration)
        {
            Temperature = temperature;
            Humidity = humidity;
            Duration = duration;
        }

        public virtual void TurnOn()
        {
            Console.WriteLine(" Device is turn on.");
        }

        public int CalculateEnergyUsage(int duration, int choice)
        {
            int watt = 40;
            int calculateEnergyUsage = 0;
            int i;

            for (i = 1; i <= duration / 60; i++)
            {
                calculateEnergyUsage = watt * i;
            }
            
            return calculateEnergyUsage;
        }

        public double CalculateEnergyUsage(double duration, double choice)
        {
            double wattHumidifier = 40.0;
            double wattAirConditioner = 3000.0;
            double wattHeater = 2500.0;
            double calculateEnergyUsage = 0.0;
            int i;
            double countHours = 0.0;
            double coefficient = 1.2;

            for (i = 1; i <= duration / 60; i++)
            {
                countHours = i;
            }

            switch (choice)
            {
                case 1:
                    calculateEnergyUsage = wattAirConditioner * countHours * coefficient;
                    break;
                case 2:
                    calculateEnergyUsage = wattHeater * countHours * coefficient;
                    break;
                case 3:
                    calculateEnergyUsage = wattHumidifier * countHours * coefficient;
                    break;
            }

            return calculateEnergyUsage;
        }

        public void String()
        {
            Console.WriteLine(" {0}, {1}, {2}", Temperature, Humidity, Duration);
        }
    }
}
