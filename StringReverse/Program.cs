using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string originalString = Console.ReadLine();

            string reverseString = string.Empty;
            
            for(int i = originalString.Length-1;i >=0; i--)
            {
                reverseString += originalString[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
    }
}
