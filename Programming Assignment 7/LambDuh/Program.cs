
//Create a program that lets the user 
//enter 2 double value numbers.


//Create a lambda expression that adds the numbers.

//Create a lambda expression that multiplies the numbers.

//Create a lambda statement that 
//compares the 2 numbers and returns the smaller value.

//Use each of the lambda expressions in a 
//Console.WriteLine statement

using System;

namespace WorkingWithLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[2];
            for (int i = 0; i < digits.Length; i++)
            {
                Console.WriteLine("Enter a number");
                
                digits[i] = int.Parse(Console.ReadLine());
            }
            var sumResult = (int a, int b) =>
            {
                int calcSum = a + b;
                return calcSum;
            };
            Console.WriteLine($"The sum of {digits[0]} and {digits[1]} is {sumResult(digits[0], digits[1])}");

            var productResult = (int a, int b) =>
            {
                int calcProd = a * b;
                return calcProd;
            };
            Console.WriteLine($"The product of {digits[0]} and {digits[1]} is {productResult(digits[0], digits[1])}");

            var smallerValue = (int a, int b) =>
            {
                if (a < b)
                    return a;
                else
                    return b;
            };
            Console.WriteLine($"The smaller of the two values {digits[0]} and {digits[1]} is: {smallerValue(digits[0], digits[1])}");




        }
    }
}