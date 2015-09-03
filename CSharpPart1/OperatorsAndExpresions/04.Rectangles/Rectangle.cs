using System;

class Rectangle
{
    private static void Main()
    {
        double width, height, perimeter, area;
        Console.WriteLine("Enter width :");
        width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        height = double.Parse(Console.ReadLine());
        perimeter = 2 * width + height * 2;
        area = height * width;
        Console.WriteLine("Perimeter of the rectangle is: {0}",perimeter);
        Console.WriteLine("Area of the rectangle is: {0}",area);
        
    }
 
}