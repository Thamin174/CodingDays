using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int digitCount = 0;
            int[] digitArray = new int[10];
            double sum = 0;

            Console.WriteLine("Enetr a number to check a armstrong number:");
            int number = int.Parse(Console.ReadLine());

            int tempNumber = number;

            while(number > 0)
            {
                digitArray[i++] = number % 10;
                number = number / 10;
                digitCount++;
            }

            for (i = 0; i < digitCount; i++)
            {
                sum += Math.Pow(digitArray[i], digitCount);
            }
            if (sum == tempNumber)
            {
                Console.WriteLine($"The Number {tempNumber} is armstrong");
            }
            else
            {
                Console.WriteLine($"The Number {tempNumber} is not armstrong");
            }
            Console.ReadLine();
        }
    }
}
