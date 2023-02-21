using System;
using System.Drawing;
using System.Xml;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    class Dog : Animal
    {
        public double age;
        public double weight;
        public string color;
        public Dog()
            : base()  
        {
            age = 0;
            weight = 0;
            color= "";
        }
        //parameterized constructor
        public Dog(double age, double weight, string color)
            : base()
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }

        public new void display()
        {
            Console.WriteLine($"I am a Dog, my name is {name}, I am {age} years old, my weight is {weight}lbs, and I am {color}.");
        }
        
    }

    class Chinchilla : Animal
    {
        public double age;
        public double weight;
        public string color;
        public Chinchilla()
            : base()
        {
            age = 0;
            weight = 0;
            color = "";
        }
        //parameterized constructor
        public Chinchilla(double age, double weight, string color)
            : base()
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }

        public new void display()
        {
            Console.WriteLine($"I am a Chinchilla, my name is {name}, I am {age} years old, my weight is {weight}lbs, and I am {color}.");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            Dog myFirstDog = new Dog();
            myFirstDog.name = "Mack";
            myFirstDog.age= 4;
            myFirstDog.weight = 90;
            myFirstDog.color = "white";
            myFirstDog.display();

            Chinchilla myFirstChinchilla = new Chinchilla();
            myFirstChinchilla.name = "Baily";
            myFirstChinchilla.age = 4;
            myFirstChinchilla.weight = 1;
            myFirstChinchilla.color = "grey";
            myFirstChinchilla.display();

            Dog mySecondDog = new Dog(6, 20, "brown");
            mySecondDog.name = "Barf";
            mySecondDog.display();

            Chinchilla mySecondChinchilla = new Chinchilla(3, 2, "black");
            mySecondChinchilla.name = "Doofus";
            mySecondChinchilla.display();

        }

    }
}
