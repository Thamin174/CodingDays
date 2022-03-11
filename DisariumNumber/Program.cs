using System;

namespace DisariumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            string strnum = num.ToString();
            int length = strnum.Length;

            int sum = 0, divide = 0, copy = num;
            while(copy > 0)
            {
                divide = copy % 10;
                sum = sum + (int)Math.Pow(divide, length);
                length--;
                copy = copy / 10;
            }
            

            if (sum == num)
            {
                Console.WriteLine($"{num} is a Disarium Number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Disarium Number");
            }
            Console.ReadKey();
        }
    }
}
