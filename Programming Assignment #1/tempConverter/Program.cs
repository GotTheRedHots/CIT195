using System;

namespace tempConverter
{
    class temps
    {
        public static void Main(string[] args)
        {
            string numberType;
            int intNumToConvert;
            double dblNumToConvert;
            char type = menu();
            while (type != 'Q')
            {
                try
                {
                    Console.WriteLine("Do you want to enter a whole number or real number? (type 'whole' or 'real') ");
                    numberType = Console.ReadLine();
                    while (numberType != "whole" && numberType != "real")
                    {
                        Console.WriteLine("Please try again, type either 'whole' or 'real'");
                        numberType = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the temp you want converted");
                    if (numberType == "whole")
                    {
                        intNumToConvert = int.Parse(Console.ReadLine());
                        convertTemp(type, intNumToConvert);
                    }
                    else
                    {
                        dblNumToConvert = double.Parse(Console.ReadLine());
                        convertTemp(type, dblNumToConvert);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You have entered bad data");
                    Console.WriteLine(e.Message);
                }
                catch
                {
                    Console.WriteLine("An error occurred, please try again.");
                }
                type = menu();

            }

        }

        private static void convertTemp(char type, int intNumToConvert)
        {
            var newTemp = 0;
            if (type == 'F')
            { 
                newTemp = (intNumToConvert - 32) * 5 / 9;
                Console.WriteLine($"{intNumToConvert} degrees Fahrenheit converted to celsius is {newTemp}.");
            }
            if (type == 'C')
            { 
                newTemp = (intNumToConvert * 9 / 5) + 32;
                Console.WriteLine($"{intNumToConvert} degrees Celcius converted to fahrenheit is {newTemp}.");
            }
        }

        private static void convertTemp(char type, double intNumToConvert)
        {
            var newTemp = 0;
            if (type == 'F')
            {
                newTemp = (int)((intNumToConvert - 32) * 5 / 9);
                Console.WriteLine($"{intNumToConvert} degrees Fahrenheit converted to celsius is {newTemp}.");
            }
            if (type == 'C')
            {
                newTemp = (int)((intNumToConvert * 9 / 5) + 32);
                Console.WriteLine($"{intNumToConvert} degrees Celcius converted to fahrenheit is {newTemp}.");
            }
        }

        private static char menu()
        {
            Console.Write("What temperature are you converting to: ");
            Console.WriteLine("C=celsius, F=fahrenheit, Q=quit");
            int t = Console.Read();
            Console.ReadLine();
            char type = Convert.ToChar(t);
            type = char.ToUpper(type);
            while (type != 'C' && type != 'F' && type != 'Q')
            {
                Console.WriteLine("Try again, select C=celsius, F=fahrenheit, Q=quit");
                t = Console.Read();
                Console.ReadLine();
                type = Convert.ToChar(t);
                type = char.ToUpper(type);
            }
            return type;
        }

    }
}