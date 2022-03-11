using System;

namespace CircularRoationOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneDimentionalArray = new int[6];
            Console.WriteLine("Enter a array eliment");
            for(int i =0; i < oneDimentionalArray.Length; i++)
            {
                oneDimentionalArray[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            for(int j =0; j < oneDimentionalArray.Length - 1; j++)
            {
                temp = oneDimentionalArray[0];
                oneDimentionalArray[0] = oneDimentionalArray[j + 1];
                oneDimentionalArray[j + 1] = temp;
            }
            Console.WriteLine("Array Elements After Right Circular Rotation: ");
            foreach (int item in oneDimentionalArray)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadKey();
        }
    }
}
