using System;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal no:");
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; number > 0; i++)
            {
                result = number % 2 + result;
                number = number / 2;
            }
            Console.WriteLine($"Binary representation of a number is {result}");
            Console.ReadKey();
        }
    }
}
