using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_Siadro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature;
            int humidity;
            int duration;
            int choice;
            bool isInputCorrect = true;

            Console.WriteLine("\n Welcome! Which device do you prefer to use?" +
                "\n [1] Air conditioner" +
                "\n [2] Heater" +
                "\n [3] Air humidifier" +
                "\n [4] Exit");
            Console.Write("\n Your choice (number): ");

            while (isInputCorrect)
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ClimateDevice device = new ClimateDevice();
                        device.String();
                        device.TurnOn();
                        int calculate1 = device.CalculateEnergyUsage(120, 1);
                        Console.WriteLine(" {0} Watt", calculate1);
                        double calculate2 = device.CalculateEnergyUsage(120, 1);
                        Console.WriteLine(" {0} Watt", calculate2);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n Oh, are you sure about that? (Т_Т)" +
                            "\n [1] Yes" +
                            "\n [2] No, can I go back in?");
                        Console.Write("\n Your choice (number): ");

                        switch (choice)
                        {
                            case 1:
                                isInputCorrect = false;
                                Console.WriteLine("\n The application is now complete.");
                                break;
                        }
                        break;
                    default:

                        Console.Write(" Sorry, try again!" +
                            " Your choice (number): ");
                        continue;
                }
            }
        }
    }
}
