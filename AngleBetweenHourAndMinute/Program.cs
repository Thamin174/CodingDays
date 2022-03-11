using System;

namespace AngleBetweenHourAndMinute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute");
            int minutes = int.Parse(Console.ReadLine());

            double hoursInDegree = (hours * 30) + (minutes * 30.0 / 60);
            double minuteInDegree = minutes * 6;

            double diff = Math.Abs(hoursInDegree - minuteInDegree);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {diff} degrees");
            Console.ReadKey();
        }
    }
}
