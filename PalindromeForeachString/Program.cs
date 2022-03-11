using System;

namespace PalindromeForeachString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);

            //Console.WriteLine($"Reverse string is {reverse}");

            if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }

            Console.ReadKey();
        }   
    }
}
