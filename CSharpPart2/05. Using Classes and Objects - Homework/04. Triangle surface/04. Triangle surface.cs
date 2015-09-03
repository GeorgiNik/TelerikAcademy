/*•	Write methods that calculate the surface of a triangle by given:
            o	Side and an altitude to it;
            o	Three sides;
            o	Two sides and an angle between them;
          •	Use System.Math.*/
using System;

class TriangleSurface
{
    static double SideAndAltitude(double side,double alt)
    {
        double surface = (side * alt) / 2;
        return surface;
    }
    static double ThreeSides(double a,double b,double c)
    {
        double p = (a + b + c) / 2;
        double result = Math.Sqrt(p * (p - a)*(p - b)*(p - c));
        return result;
    }
    static double TwoSidesAngle(double a,double b,double angle)
    {
        return (a * b * Math.Sin(angle)) / 2;
    }
    static void Main()
    {
        Console.WriteLine("This is a program that calculate the surface of a triangle by given:");
        Console.WriteLine("1) Side and an altitude to it");
        Console.WriteLine("2) Three sides");
        Console.WriteLine("3) Two sides and an angle between them");
        Console.WriteLine("Please choose an option: 1, 2 or 3");
        

        try
        {

            int input = int.Parse(Console.ReadLine());
            
             if (input == 1)
            {
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude: ");
                double altitude = double.Parse(Console.ReadLine());
                Console.WriteLine("Area = {0:F2}", SideAndAltitude(side, altitude));
            }
            else if (input == 2)
            {
                Console.Write("Enter first side: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter second side: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Enter third side: ");
                double sideC = double.Parse(Console.ReadLine());
                Console.WriteLine("Area = {0:F2}", ThreeSides(sideA, sideB, sideC));
            }
            else if (input == 3)
            {
                Console.Write("Enter first side: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter second side: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Enter an angle: ");
                int angle = int.Parse(Console.ReadLine());
                Console.WriteLine("Area = {0:F2}", TwoSidesAngle(sideA, sideB, angle));
            }
            else
            {
                Console.WriteLine("Number must be between 1 and 3!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}

