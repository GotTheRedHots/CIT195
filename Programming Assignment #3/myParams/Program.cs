using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("Enter the quantity of random numbers: ");
        var quantity = int.Parse(Console.ReadLine());
        var numbers = new int[quantity];
        for (int i = 0; i < quantity; i++)
        {
            numbers[i] = r.Next();
        }
        Console.WriteLine("Numbers:");
        for (int i = 0;i < numbers.Length;i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();
        Console.WriteLine($"Total of the numbers array={Add(numbers)}");
        Console.WriteLine($"Total of the subset array={Multiply(numbers)}");
    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    static int Multiply(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}