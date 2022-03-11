using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            };

            Console.WriteLine($"The factorial of {num} is {factorial}");
            Console.ReadKey();
        }
    }
}
