using System;

namespace RightCirculationArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] OneDimentionalArray = new int[6];
            Console.WriteLine("Enter eliments of array");

            for (int i = 0; i < OneDimentionalArray.Length; i++)
            {
                OneDimentionalArray[i] = int.Parse(Console.ReadLine());
            }
            int temp;

            for (int j = 0; j < OneDimentionalArray.Length -1; j++)
            {
                temp = OneDimentionalArray[0];
                OneDimentionalArray[0] = OneDimentionalArray[j + 1];
                OneDimentionalArray[j + 1] = temp;
            }

            Console.WriteLine("Array Elements After Right Circular Rotation: ");
            foreach (var item in OneDimentionalArray)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadKey();

        }
    }
}
