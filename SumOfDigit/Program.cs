using System;

namespace SumOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder, sum = 0;
            Console.WriteLine("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            while(number > 0)
            {
                remainder = number % 10;
                sum += remainder;
                number = number / 10;
            }
            Console.WriteLine($"The Sum of digit is {sum}");
            Console.ReadKey();
        }
    }
}
