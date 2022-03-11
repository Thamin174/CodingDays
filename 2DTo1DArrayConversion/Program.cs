using System;

namespace _2DTo1DArrayConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] int2DArray = new int[2, 3];
            Console.WriteLine("Eneter 2D array eliment");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int2DArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int index = 0;
            int NoOfRows = int2DArray.GetLength(0);
            int NoOfColumns = int2DArray.GetLength(1);
            

            int[] OneDimensionalArray = new int[NoOfRows * NoOfColumns];

            for (int y = 0; y < NoOfColumns; y++)
            {
                for (int x = 0; x < NoOfRows; x++)
                {
                    OneDimensionalArray[index] = int2DArray[x, y];
                    index++;
                }
            }

            Console.WriteLine("1D Array Element: ");
            foreach (int item in OneDimensionalArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
