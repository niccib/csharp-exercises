using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles, gallons;
            Console.WriteLine("How many miles have you driven?");
            miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many whole gallons have you used?");
            gallons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are getting {0} miles per gallon", miles / gallons);
            Console.ReadLine();
        }
    }
}
