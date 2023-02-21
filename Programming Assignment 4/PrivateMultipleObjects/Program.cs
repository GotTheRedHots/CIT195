using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Xml;

namespace ArrayOfClassObjects
{

    // base class
    class vehicle
    {
        private string type;
        private string size;
        private int year;

        // constructor
        public vehicle()
        {
            type = "";
            size = "";
            year= 0;

        }
        //parameterized constructor
        public vehicle(string type, string size, int year)
        {
            this.type = type;
            this.size = size;
            this.year = year;
        }
        public string getType() { return type; }
        public void setType(string type) { this.type = type; }
        public string getSize() { return size; }
        public void setSize(string size) { this.size = size; }
        public int getYear() { return year; }
        public void setYear(int year) { this.year = year; }

        public virtual void display()
        {
            Console.WriteLine($"This vehicle is a {size},{type} made in {year}");
        }
        public virtual void addChange()
        {
            Console.Write("Type=");
            setType(Console.ReadLine());
            Console.Write("Size=");
            setSize(Console.ReadLine());
            Console.Write("Year=");
            setYear(int.Parse(Console.ReadLine()));
        }
        public virtual void print()
        {
            Console.WriteLine();
            Console.WriteLine($"    Type: {getType()}");
            Console.WriteLine($"    Size: {getSize()}");
            Console.WriteLine($"    Year: {getYear()}");
        }

    }

    class Car : vehicle
    {
        private string make;
        private string model;
        public string color;
        public Car()
            : base()
        {
            make = "";
            model = "";
            color = "";
        }
        //parameterized constructor
        public Car(string make, string model, string color)
            : base()
        {
            this.make = make;
            this.model = model;
            this.color = color;
        }
        public string getMake() { return make; }
        public void setMake(string make) { this.make = make; }
        public string getModel() { return model; }
        public void setModel(string model) { this.model = model; }
        public string getColor() { return color; }
        public void setColor(string color) { this.color = color; }

        public override void display()
        {
            Console.WriteLine($"This car is a {color}{make}{model}.");
        }
        public override void addChange()
        {
            Console.Write("Type=");
            setType(Console.ReadLine());
            Console.Write("Size=");
            setSize(Console.ReadLine());
            Console.Write("Year=");
            setYear(int.Parse(Console.ReadLine()));
            Console.Write("Make=");
            setMake(Console.ReadLine());
            Console.Write("Model=");
            setModel(Console.ReadLine());
            Console.Write("Color=");
            setColor(Console.ReadLine());

        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"    Make: {getMake()}");
            Console.WriteLine($"    Model: {getModel()}");
            Console.WriteLine($"    Color: {getColor()}");
            Console.WriteLine();
        }


    }

    class Program
    { 
        static void Main(string[] args)
        {

            Console.WriteLine("How many vehicles do you have?");
            int maxvehicles;
            while (!int.TryParse(Console.ReadLine(), out maxvehicles))
                Console.WriteLine("Please enter a whole number");
            // array of Employee objects
            vehicle[] vehicles = new vehicle[maxvehicles];
            Console.WriteLine("How many cars do you have?");
            int maxcars;
            while (!int.TryParse(Console.ReadLine(), out maxcars))
                Console.WriteLine("Please enter a whole number");
            // array of Manager objects
            Car[] cars = new Car[maxcars];

            int choice, rec, type;
            int carCounter = 0, vehicleCounter = 0;
            choice = Menu();
            while (choice != 4)
            {
                Console.WriteLine("Enter 1 for vehicle or 2 for car");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for vehicle or 2 for car");
                try
                {
                    switch (choice)
                    {
                        case 1: // Add
                            if (type == 1) //vehicle
                            {
                                if (vehicleCounter <= maxvehicles)
                                {
                                    vehicles[vehicleCounter] = new vehicle(); // places an object in the array instead of null
                                    vehicles[vehicleCounter].addChange();
                                    vehicleCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of managers has been added");

                            }
                            else //car
                            {
                                if (carCounter <= maxcars)
                                {
                                    cars[carCounter] = new Car(); // places an object in the array instead of null
                                    cars[carCounter].addChange();
                                    carCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of vehicles has been added");
                            }

                            break;
                        case 2: //Change
                            Console.Write("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;  // subtract 1 because array index begins at 0
                            if (type == 1) //Manager
                            {
                                while (rec > vehicleCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                vehicles[rec].addChange();
                            }
                            else // Employee
                            {
                                while (rec > carCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                cars[rec].addChange();
                            }
                            break;
                        case 3: // Print All
                            if (type == 1) //vehicle
                            {
                                for (int i = 0; i < vehicleCounter; i++)
                                    vehicles[i].print();
                            }
                            else // car
                            {
                                for (int i = 0; i < carCounter; i++)
                                    cars[i].print();
                            }
                            break;
                        default:
                            Console.WriteLine("You made an invalid selection, please try again");
                            break;
                    }
                }


                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                choice = Menu();

            }
        }


        private static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}