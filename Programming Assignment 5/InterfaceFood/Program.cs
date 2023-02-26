using System;
namespace Food
{
    public interface IEdible
    {
        //Properties
        public int Calories { get; set; }
        public string UtensilEatenWith { get; }

        public int Servings { get; set; }

        public int CaloriesTotal();

    }
    class Program
    {
        class Meal : IEdible
        {
            public int Calories { get; set; }
            public string UtensilEatenWith { get; set; }
            public string Cuisine { get; set; }

            public string NameOfDish { get; set; }

            public int Servings { get; set; }

            public Meal()
            {
                Calories = 0;
                UtensilEatenWith = string.Empty;
                Cuisine = string.Empty;
                Servings = 0;  
                NameOfDish= string.Empty;

            }
            public Meal(int calories, string utensilEatenWith, string cuisine, int servings, string nameOfDish)
            {
                Calories = calories;
                UtensilEatenWith = utensilEatenWith;
                Cuisine = cuisine;
                Servings = servings;
                NameOfDish = nameOfDish;

            }

            public void Describe()
            {
                Console.WriteLine($"{NameOfDish} is a {Cuisine} dish and is eaten with a {UtensilEatenWith}.");
            }

            public int CaloriesTotal()
            {
                return Calories + Servings;
            }
        }
        static void Main(string[] args)
        {
           Meal spagetti= new Meal(500, "fork", "Italian", 2, "spagetti");
           spagetti.Describe();
           Console.WriteLine($"This meal provides {spagetti.CaloriesTotal()} calories.");

        }
    }
}