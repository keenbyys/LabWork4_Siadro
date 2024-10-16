using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LW4_Siadro
{
    class ClimateDevice
    {
        private double temperature;
        private int humidity;
        private double duration;

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

        public double Duration
        {
            get { return duration; }
            set { if (value > 0)
                duration = value; }
        }

        public ClimateDevice()
        {
            temperature = 10;
            humidity = 30;
            duration = 60;
        }

        public ClimateDevice(double temperature, int humidity, double duration)
        {
            Temperature = temperature;
            Humidity = humidity;
            Duration = duration;
        }

        public virtual void TurnOn()
        {
            Console.WriteLine(" Device is turn on.");
        }

        public double CalculateEnergyUsage()
        {
            double watt = 0.04;
            double calculateEnergyUsage = 0;
            double countHours;


            countHours = duration / 60;

            calculateEnergyUsage = watt * countHours;

            return calculateEnergyUsage;
        }

        public double CalculateEnergyUsage(int choice)
        {
            double kilowattsHumidifier = 0.04;
            double kilowattsAirConditioner = 3;
            double kilowattsHeater = 2.5;

            double countHours;

            double coefficientAirConditioner = 1.5;
            double coefficientHeater = 1.2;
            double coefficientHumidifier = 0.8;

            double calculateEnergyUsage = 0.0;

            countHours = duration / 60;

            switch (choice)
            {
                case 1:
                    calculateEnergyUsage = kilowattsAirConditioner * countHours * coefficientAirConditioner;
                    break;
                case 2:
                    calculateEnergyUsage = kilowattsHeater * countHours * coefficientHeater;
                    break;
                case 3:
                    calculateEnergyUsage = kilowattsHumidifier * countHours * coefficientHumidifier;
                    break;
            }

            return calculateEnergyUsage;
        }

        public virtual void SetUp()
        {
            Console.WriteLine(" Device has default data.");
        }

        public virtual void String()
        {
            Console.WriteLine("\n Temperature = {0} degrees Celsius." +
                "\n Duration = {1} min." +
                "\n Humidity = {2}%", Temperature, Duration, Humidity);
        }
    }
}
