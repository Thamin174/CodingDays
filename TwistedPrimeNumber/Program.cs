using System;

namespace TwistedPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());

            int revNo = RevNumber(num);

            if (IsPrime(num) && IsPrime(revNo))
            {
                Console.WriteLine($"{num} is Twisted Prime No");
            }
            else
            {
                Console.WriteLine($"{num} is not a Twisted Prime No");
            }


        }

        public static int RevNumber(int num)
        {
            int revNo = 0;
            while (num > 0)
            {
                revNo = (revNo * 10) + num % 10;
                num = num / 10;
            }
            return revNo;
        }

        public static bool IsPrime(int num)
        {
            bool isPrime = true;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
