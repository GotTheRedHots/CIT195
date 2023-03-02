using System;
using static recordDemo.Program;

namespace recordDemo
{
    class Program
    {
        public record Bookstore(int ID, string Title, string Author, double Price);

        public static void Main()
        {
            Bookstore firstBook = new(4532,"Twenty Thousand Leagues Under the Sea", "Jules Verne", 19.99);
            Bookstore secondBook = new(4536, "Journey to the Center of the Earth", "Jules Verne", 19.25);
            Bookstore thirdBook = new(4539, "Around the World in Eighty Days", "Jules Verne", 17.99);
            Console.WriteLine(firstBook);
            Console.WriteLine(secondBook);
            Console.WriteLine(thirdBook);

        }
    }
}