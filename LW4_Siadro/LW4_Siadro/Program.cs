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
        private static AirConditioner airConditionerManually;
        static void MainMenu()
        {
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
                        Console.Clear();
                        AirConditionerMenu();
                        isInputCorrect = false;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Exit();
                        isInputCorrect = false;
                        break;
                }
            }
        }

        static void AirConditionerMenu()
        {
            int choice;
            bool isInputCorrect = true;

            Console.WriteLine("\n You've chosen an air conditioner." +
                "\n [1] Turn on" +
                "\n [2] Check info" +
                "\n [3] Air humidifier" +
                "\n [4] Return to main menu");

            while (isInputCorrect)
            {
                Console.Write("\n Your choice (number): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                { 
                    case 1:
                        Console.Clear();
                        CreateAirConditionerMenu();
                        break;

                    case 2:
                        Console.Clear();
                        CheckDeviceInfo();
                        break;

                    case 4:
                        Console.Clear();
                        MainMenu();
                        isInputCorrect = false;
                        break;
                }
            }
        }

        static void CreateAirConditionerMenu()
        {
            int choice;
            bool isInputCorrect = true;

            Console.WriteLine("\n What data should I set?" +
                "\n [1] Set default" +
                "\n [2] Set manually" +
                "\n [3] Return");
            Console.Write("\n Your choice (number): ");

            while (isInputCorrect)
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        AirConditioner airConditionerDefault = new AirConditioner();
                        airConditionerDefault.TurnOn();
                        AirConditionerMenu();
                        isInputCorrect = false;
                        break;

                    case 2:
                        Console.Clear();
                        UserInputDataAirConditioner();
                        isInputCorrect = false;
                        break;

                    case 3: 
                        Console.Clear();
                        AirConditionerMenu();
                        isInputCorrect = false;
                        break;
                }
            }
        }

        static void UserInputDataAirConditioner()
        {
            int choice;
            int temperature;
            bool isInputCorrect = true;

            Console.WriteLine("\n What temperature do you want to set to cool the room?" +
                "\n [Range 10 to 40 degrees]");
            Console.Write("\n Your choice (number): ");

            while (isInputCorrect)
            {
                temperature = Convert.ToInt32(Console.ReadLine());

                switch (temperature)
                {
                    case int t when (t >= 10 && t <= 40):
                        Console.Clear();
                        airConditionerManually = new AirConditioner(temperature);
                        airConditionerManually.TurnOn();
                        AirConditionerMenu();
                        isInputCorrect = false;
                        break;

                    default:
                        Console.Write("\n The value is outside the specified range." +
                            "\n Try again: ");
                        break;
                }
            }
        }

        static void CheckDeviceInfo()
        {
            switch (airConditionerManually) 
            {
                case null: 
                    Console.WriteLine("\n You have not set the correct values!" +
                        "\n Try selecting “Turn on” ");
                    AirConditionerMenu();
                    break;

                default:
                    airConditionerManually.String();
                    AirConditionerMenu();
                    break;
            }

        }

        // функція завершення програми
        static void Exit()
        {
            bool isInputCorrect = true;
            Console.Clear();
            Console.WriteLine("\n Oh, are you sure about that? (Т_Т)" +
                "\n [1] Yes" +
                "\n [2] No, can I go back in?");
            Console.Write("\n Your choice (number): ");

            while (isInputCorrect)
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        isInputCorrect = false;
                        Console.WriteLine("\n The application is now complete.\n");
                        break;
                    case 2:
                        Console.Clear();
                        MainMenu();
                        isInputCorrect = false;
                        break;
                }
            }
        }

        static void Main(string[] args)
        {

            MainMenu();
        }
    }
}
