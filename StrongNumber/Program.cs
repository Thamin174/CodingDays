using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int quot = number;
            int remainder, sum = 0;

            while(quot != 0)
            {
                remainder = quot % 10;
                int fact = CalculateFactorial(remainder);
                quot = quot / 10;
                sum = sum + fact;
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} is a strong number");
            }
            else
            {
                Console.WriteLine($"{number} is not a strong number");
            }
        }

        public static int CalculateFactorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
