using System;

namespace Area
{
    class Area
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double radius;
            Console.WriteLine("Please enter the radius of the circle");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the circle {0}", pi * radius * radius);
            Console.ReadLine();

        }
    }
}