using System;

namespace BinaryToDeciamalConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter a Binary number:");
            int binaryNumber = int.Parse(Console.ReadLine());

            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            Console.WriteLine($"Decimal Value: {decimalValue}");
            Console.ReadKey();
        }
    }
}
