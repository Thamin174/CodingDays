using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int remainder, sum = 0;
            int temp = number;

            while(number > 0)
            {
                remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine($"The reverse no of {temp} is {sum}");
            Console.ReadKey();
        }
    }
}
