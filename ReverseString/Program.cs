using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);

            Console.WriteLine($"The reverse word of {name} is {reverse}");
        }
    }
}
