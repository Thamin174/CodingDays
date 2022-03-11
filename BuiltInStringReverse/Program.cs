using System;

namespace BuiltInStringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter a string:");
            string originalString = Console.ReadLine();

            char[] nameArray = originalString.ToCharArray();
            Array.Reverse(nameArray);
            string reverseString = new string(nameArray);

            Console.WriteLine($"{reverseString}");
            Console.ReadKey();
        }
    }
}
