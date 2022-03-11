using System;

namespace AmstrongNumberRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start number:");
            int startNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end number:");
            int endNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Amstrong number in between {startNumber} and {endNumber} are :");
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsArmStrongNumber(i))
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static bool IsArmStrongNumber(int number)
        {
            int sum = 0;
            int temporaryNumber = number;
            int temp = 0;
            int length = number.ToString().Length;

            while(number != 0)
            {
                temp = number % 10;
                number = number / 10;
                sum += (int)Math.Pow(temp, length);
            }
            if (sum == temporaryNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
