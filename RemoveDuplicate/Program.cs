using System;

namespace RemoveDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter a string:");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine($"{resultString}");
            Console.ReadKey();
        }
    }
}
