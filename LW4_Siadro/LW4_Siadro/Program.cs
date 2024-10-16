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
        private static AirConditioner airConditioner;
        private static Heater heater;
        private static AirHumidifier airHumidifier;
        
        private static double duration;
        private static int temperature;
        private static int humidity;
        private static int choice;
        private static bool isInputCorrect = true;

        // MAIN MENU
        static void MainMenu()
        {
            Console.WriteLine("\n Welcome! Which device do you prefer to use?" +
                "\n [1] Air conditioner" +
                "\n [2] Heater" +
                "\n [3] Air humidifier" +
                "\n [4] Exit");

            while (isInputCorrect)
            {
                try
                {
                    Console.Write("\n Your choice (number): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            AirConditionerMenu(); // меню пристрою: кондиционер
                            isInputCorrect = false;
                            break;
                        case 2:
                            Console.Clear();
                            HeaterMenu();
                            isInputCorrect = false;
                            break;
                        case 3:
                            Console.Clear();
                            AirHumidifierMenu();
                            isInputCorrect = false;
                            break;
                        case 4:
                            Console.Clear();
                            Exit(); // меню: вихід із програми
                            isInputCorrect = false;
                            break;
                    }
                }
                catch 
                {
                    Console.Clear();   
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    MainMenu();
                    isInputCorrect = false;
                }
            }
        }

        // AIR CONDITIONER
        static void AirConditionerMenu()
        {
            Console.WriteLine("\n You've chosen an air conditioner." +
                "\n [1] Turn on" +
                "\n [2] Check info" +
                "\n [3] Wasted electricity" +
                "\n [4] Return to main menu");

            while (isInputCorrect)
            {
                try
                {
                    Console.Write("\n Your choice (number): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            CreateClimateDeviceMenu(1); // меню: 
                            isInputCorrect = false;
                            break;

                        case 2:
                            Console.Clear();
                            CheckClimateDeviceInfo(1); // вивід інформації в меню
                            isInputCorrect = false;
                            break;

                        case 3:
                            Console.Clear();
                            CheckingExistenceClimateDevice(1); // перевірка на існування даних
                            isInputCorrect = false;
                            break;

                        case 4:
                            Console.Clear();
                            airConditioner = null;
                            MainMenu(); // повернення в головне меню
                            isInputCorrect = false;
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    AirConditionerMenu();
                    isInputCorrect = false;
                }
                
            }
        }

        // HEATER
        static void HeaterMenu()
        {
            Console.WriteLine("\n You've chosen a heater." +
                "\n [1] Turn on" +
                "\n [2] Check info" +
                "\n [3] Wasted electricity" +
                "\n [4] Return to main menu");

            while (isInputCorrect)
            {
                try
                {
                    Console.Write("\n Your choice (number): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            CreateClimateDeviceMenu(2);
                            isInputCorrect = false;
                            break;

                        case 2:
                            Console.Clear();
                            CheckClimateDeviceInfo(2);
                            isInputCorrect = false;
                            break;

                        case 3:
                            Console.Clear();
                            CheckingExistenceClimateDevice(2);
                            isInputCorrect = false;
                            break;

                        case 4:
                            Console.Clear();
                            heater = null;
                            MainMenu();
                            isInputCorrect = false;
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    HeaterMenu();
                    isInputCorrect = false;
                }

            }
        }

        // AIR HUMIDIFIER
        static void AirHumidifierMenu()
        {
            Console.WriteLine("\n You've chosen an air humidifier." +
                "\n [1] Turn on" +
                "\n [2] Check info" +
                "\n [3] Wasted electricity" +
                "\n [4] Return to main menu");

            while (isInputCorrect)
            {
                try
                {
                    Console.Write("\n Your choice (number): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            CreateClimateDeviceMenu(3); // меню: 
                            isInputCorrect = false;
                            break;

                        case 2:
                            Console.Clear();
                            CheckClimateDeviceInfo(3); // вивід інформації в меню
                            isInputCorrect = false;
                            break;

                        case 3:
                            Console.Clear();
                            CheckingExistenceClimateDevice(3); // перевірка на існування даних
                            isInputCorrect = false;
                            break;

                        case 4:
                            Console.Clear();
                            airHumidifier = null;
                            MainMenu(); // повернення в головне меню
                            isInputCorrect = false;
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    AirHumidifierMenu();
                    isInputCorrect = false;
                }

            }
        }

        // ACTS
        static void CreateClimateDeviceMenu(int choiceDevice)
        {
            Console.WriteLine("\n What data should I set?" +
                "\n [1] Set default" +
                "\n [2] Set manually" +
                "\n [3] Return");
            
            while (isInputCorrect)
            {
                try
                {
                    Console.Write("\n Your choice (number): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            switch (choiceDevice)
                            {
                                case 1:
                                    Console.Clear();
                                    airConditioner = new AirConditioner();
                                    airConditioner.SetUp();
                                    AirConditionerMenu();
                                    isInputCorrect = false;
                                    break;

                                case 2:
                                    Console.Clear();
                                    heater = new Heater();
                                    heater.SetUp();
                                    HeaterMenu();
                                    isInputCorrect = false;
                                    break;

                                case 3:
                                    Console.Clear();
                                    airHumidifier = new AirHumidifier();
                                    airHumidifier.SetUp();
                                    AirHumidifierMenu();
                                    isInputCorrect = false;
                                    break;
                            }
                            break;

                        case 2:
                            switch (choiceDevice) 
                            {
                                case 1:
                                    Console.Clear();
                                    UserInputDataClimateDevice(choiceDevice);
                                    isInputCorrect = false;
                                    break;
                                
                                case 2:
                                    Console.Clear();
                                    UserInputDataClimateDevice(choiceDevice);
                                    isInputCorrect = false;
                                    break;

                                case 3:
                                    Console.Clear();
                                    UserInputDataClimateDevice(choiceDevice);
                                    isInputCorrect = false;
                                    break;
                            }
                            
                            break;

                        case 3:
                            switch (choiceDevice) 
                            {
                                case 1:
                                    Console.Clear();
                                    AirConditionerMenu();
                                    isInputCorrect = false;
                                    break; 
                                case 2:
                                    Console.Clear();
                                    HeaterMenu();
                                    isInputCorrect = false;
                                    break;

                                case 3:
                                    Console.Clear();
                                    AirHumidifierMenu();
                                    isInputCorrect = false;
                                    break;
                            }
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    CreateClimateDeviceMenu(choiceDevice);
                    isInputCorrect = false;
                }
            }
        }

        static void UserInputDataClimateDevice(int choiceDevice)
        {
            while (isInputCorrect)
            {
                try
                {
                    switch (choiceDevice)
                    {
                        case 1:
                            Console.WriteLine("\n What temperature do you want to set to cool the room?" +
                                "\n [Range 10 to 40 degrees]");

                            Console.Write("\n Your choice (number): ");
                            temperature = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 2:
                            Console.WriteLine("\n What temperature do you want to set to heat the room?" +
                                "\n [Range 10 to 40 degrees]");

                            Console.Write("\n Your choice (number): ");
                            temperature = Convert.ToInt32(Console.ReadLine());
                            break;
                           
                        case 3:
                            Console.WriteLine("\n What humidity do you want to set for the room?" +
                                "\n [Range 20 to 80 degrees]");

                            Console.Write("\n Your choice (number): ");
                            humidity = Convert.ToInt32(Console.ReadLine());
                            break;
                    }

                    Console.WriteLine("\n What value do you want to set the device runtime to?" +
                        "\n [Number in minutes]");

                    Console.Write("\n Your choice (number): ");
                    duration = Convert.ToInt32(Console.ReadLine());

                    if (((temperature >= 10 && temperature <= 40) && duration > 0) || 
                        ((humidity >= 20 && humidity <= 80) && duration > 0))
                    {
                        switch (choiceDevice)
                        {
                            case 1:
                                Console.Clear();
                                airConditioner = new AirConditioner(temperature, duration);
                                airConditioner.TurnOn();
                                AirConditionerMenu();
                                isInputCorrect = false;
                                break;
                            
                            case 2:
                                Console.Clear();
                                heater = new Heater(temperature, duration);
                                heater.TurnOn();
                                HeaterMenu();
                                isInputCorrect = false;
                                break;

                            case 3:
                                Console.Clear();
                                airHumidifier = new AirHumidifier(humidity, duration);
                                airHumidifier.TurnOn();
                                AirHumidifierMenu();
                                isInputCorrect = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.Write("\n The value is outside the specified range. Try again.");
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    UserInputDataClimateDevice(choiceDevice);
                    isInputCorrect = false;
                }
            }
        }

        static void CheckClimateDeviceInfo(int choiceDevice)
        {
            while (isInputCorrect)
            {
                switch (airConditioner)
                {
                    case null:
                        Console.WriteLine("\n You have not set the correct values!" +
                            "\n Try selecting “Turn on” ");
                        switch (choiceDevice)
                        {
                            case 1:
                                AirConditionerMenu();
                                isInputCorrect = false;
                                break;

                            case 2:
                                HeaterMenu();
                                isInputCorrect = false;
                                break;

                            case 3:
                                AirHumidifierMenu();
                                isInputCorrect = false;
                                break;
                        }
                        break;

                    default:
                        switch (choiceDevice)
                        {
                            case 1:
                                airConditioner.String();
                                AirConditionerMenu();
                                isInputCorrect = false;
                                break;
                            
                            case 2:
                                heater.String();
                                HeaterMenu();
                                isInputCorrect = false;
                                break;
                            
                            case 3:
                                airHumidifier.String();
                                AirHumidifierMenu();
                                isInputCorrect = false;
                                break;
                        }
                        break;
                }

            }
        }

        static void SelectingСalculationУnergyСonsumption(int choiceDevice)
        {
            Console.WriteLine("\n Which option for calculating wasted electricity do you want to use?" +
                "\n [1] Behind the duration." +
                "\n [2] Behind the duration and temperature." +
                "\n [3] Return");

            while (isInputCorrect)
            {
                try
                {
                    Console.Write("\n Your choice (number): ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            if (duration > 0)
                            {
                                Console.Write("\n Calculation of the energy consumed, " +
                                            "\n taking into account the operating time of the device: ");

                                switch (choiceDevice)
                                {
                                    case 1:
                                        Console.Write("{0:F2} kilowatts per hour \n", airConditioner.CalculateEnergyUsage());
                                        AirConditionerMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 2:
                                        Console.Write("{0:F2} kilowatts per hour \n", heater.CalculateEnergyUsage());
                                        HeaterMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 3:
                                        Console.Write("{0:F2} kilowatts per hour \n", airHumidifier.CalculateEnergyUsage());
                                        AirHumidifierMenu();
                                        isInputCorrect = false;
                                        break;
                                }
                            }
                            else
                            {
                                Console.Write("\n The value must be greater than zero. " +
                                    "\n Or set the data for the device, e.g. with “Turn on -> Set manually”." +
                                    "\n Try again.\n");
                                
                                switch (choiceDevice)
                                {
                                    case 1:
                                        AirConditionerMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 2:
                                        HeaterMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 3:
                                        AirHumidifierMenu();
                                        isInputCorrect = false;
                                        break;
                                }
                            }
                            break;

                        case 2:
                            Console.Clear();
                            if (duration > 0)
                            {
                                Console.Write("\n Calculation of the energy consumed," +
                                    "\n taking into account the operating time of the device: ");

                                switch (choiceDevice)
                                {
                                    case 1:
                                        Console.Write("{0:F2} kilowatts per hour \n", airConditioner.CalculateEnergyUsage(choiceDevice));
                                        AirConditionerMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 2:
                                        Console.Write("{0:F2} kilowatts per hour \n", heater.CalculateEnergyUsage(choiceDevice));
                                        HeaterMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 3:
                                        Console.Write("{0:F2} kilowatts per hour \n", airHumidifier.CalculateEnergyUsage(choiceDevice));
                                        AirHumidifierMenu();
                                        isInputCorrect = false;
                                        break;
                                }
                            }
                            else
                            {
                                Console.Write("\n The value must be greater than zero. " +
                                    "\n Or set the data for the device, e.g. with “Turn on -> Set manually”." +
                                    "\n Try again.\n");
                                
                                switch (choiceDevice)
                                {
                                    case 1:
                                        AirConditionerMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 2:
                                        HeaterMenu();
                                        isInputCorrect = false;
                                        break;

                                    case 3:
                                        AirHumidifierMenu();
                                        isInputCorrect = false;
                                        break;
                                }
                            }
                            break;

                        case 3:
                            switch (choiceDevice)
                            {
                                case 1:
                                    Console.Clear();
                                    AirConditionerMenu();
                                    isInputCorrect = false;
                                    break;

                                case 2:
                                    Console.Clear();
                                    HeaterMenu();
                                    isInputCorrect = false;
                                    break;

                                case 3:
                                    Console.Clear();
                                    AirHumidifierMenu();
                                    isInputCorrect = false;
                                    break;
                            }
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    SelectingСalculationУnergyСonsumption(choiceDevice);
                    isInputCorrect = false;
                }
            }
        }

        static void CheckingExistenceClimateDevice(int choiceDevice)
        {
            while (isInputCorrect)
            {
                switch (choiceDevice)
                {
                    case 1:
                        switch (airConditioner)
                        {
                            case null:
                                Console.WriteLine("\n You have not set the correct values!" +
                                    "\n Try selecting “Turn on” ");
                                AirConditionerMenu();
                                isInputCorrect = false;
                                break;

                            default:
                                SelectingСalculationУnergyСonsumption(choiceDevice);
                                isInputCorrect = false;
                                break;
                        }
                        break;

                    case 2:
                        switch (heater)
                        {
                            case null:
                                Console.WriteLine("\n You have not set the correct values!" +
                                    "\n Try selecting “Turn on” ");
                                HeaterMenu();
                                isInputCorrect = false;
                                break;

                            default:
                                SelectingСalculationУnergyСonsumption(choiceDevice);
                                isInputCorrect = false;
                                break;
                        }
                        break;

                    case 3:
                        switch (airHumidifier)
                        {
                            case null:
                                Console.WriteLine("\n You have not set the correct values!" +
                                    "\n Try selecting “Turn on” ");
                                AirHumidifierMenu();
                                isInputCorrect = false;
                                break;

                            default:
                                SelectingСalculationУnergyСonsumption(choiceDevice);
                                isInputCorrect = false;
                                break;
                        }
                        break;
                }
            }
        }

        // EXIT
        static void Exit()
        {
            Console.WriteLine("\n Oh, are you sure about that? (Т_Т)" +
                "\n [1] Yes" +
                "\n [2] No, can I go back in?");

            while (isInputCorrect)
            {
                try
                {
                    Console.Write("\n Your choice (number): ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n The application is now complete.\n");
                            isInputCorrect = false;
                            break;
                        case 2:
                            Console.Clear();
                            MainMenu();
                            isInputCorrect = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("\n Incorrect values have been entered. Try again!");
                    Exit();
                    isInputCorrect = false;
                }
            }
        }

        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
