using System;

namespace RangePrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter initial number: ");
            int initialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number: ");
            int endNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The prime number between {initialNumber} and {endNumber} are: ");

            for (int i = initialNumber; i <= endNumber; i++)
            { 
                int counter = 0;

                for (int j = 2; j <= i/2; j++)
                {
                    if(i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 & i !=1)
                {
                    Console.Write("{0}" + " ",i);
                }
            }
            Console.ReadKey();
        }
    }
}
