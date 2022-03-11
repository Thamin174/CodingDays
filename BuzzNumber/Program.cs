using System;

namespace BuzzNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buzz number from 1 to 100: ");
            for (int number = 7; number <= 100; number++)
            {
                if (number % 10 == 7 || number % 7 == 0)
                    Console.Write(number + " ");
            }
        }
    }
}
