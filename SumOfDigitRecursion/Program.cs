using System;

namespace SumOfDigitRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int sum = SumOfDigits(number);
            Console.WriteLine($"The Sum of Digits is : {sum}");
            Console.ReadKey();
        }

        static int SumOfDigits(int number)
        {
            if (number > 0)
            {
                return (number % 10 + SumOfDigits(number / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
