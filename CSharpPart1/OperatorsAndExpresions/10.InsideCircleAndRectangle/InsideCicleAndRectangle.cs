using System;

class InsideCicleAndRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool insideCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(1.5, 2); 
        bool insideRectangle = (x >= -1 && x <= -1 + 6) && (y <= 1 && y >= -1 + 2);

        if (insideCircle && !insideRectangle)Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}
