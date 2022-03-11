using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber, noOfElements;
            Console.WriteLine("Enter the no of elements:");
            noOfElements = int.Parse(Console.ReadLine());

            if (noOfElements < 2)
            {
                Console.Write("Please enter a number greater than 2");
            }
            else
            {
                Console.Write(firstNumber + " " + secondNumber + " ");

                for (int i = 2; i < noOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            

        }
    }
}
