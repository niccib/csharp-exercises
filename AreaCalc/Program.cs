using System;

class AreaCalc
{
    static void Main()
    {
        Console.WriteLine("Enter the rectangle's height:");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the rectangle's width:");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The area of the rectangle is {0}", width * height);
        Console.ReadLine();

    }
}