using System;
using System.Linq;

namespace RemoveDuplicateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter array of element");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] dist = arr.Distinct().ToArray();
            Array.ForEach(dist, v => Console.Write(v));
        }
    }
}
