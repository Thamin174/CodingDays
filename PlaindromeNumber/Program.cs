using System;

namespace PlaindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check a Palindrome:");
            int number = int.Parse(Console.ReadLine());
            int remainder, sum = 0;
            int temp = number;

            while(number > 0)
            {
                remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
