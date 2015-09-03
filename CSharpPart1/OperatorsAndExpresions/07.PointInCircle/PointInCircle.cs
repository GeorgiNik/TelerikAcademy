using System;

class PointInCircle
{
    static void Main()
    {
        double raduis = 2;

        Console.WriteLine("Enter X coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate:");
        double y = double.Parse(Console.ReadLine());
        double point = Math.Sqrt((x * x) + (y * y));
        bool inCicle = point <= raduis;
        Console.WriteLine("The Point is IN the Circle:  {0}", inCicle);
    }
}