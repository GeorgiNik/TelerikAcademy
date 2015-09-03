using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c:");
        double c = double.Parse(Console.ReadLine());
        double discriminatnt,x1,x2;
        discriminatnt=(Math.Pow(b,2))-(4*a*c);
        if (discriminatnt<0)
        {
            Console.WriteLine("no real roots");
            
        }
        if (discriminatnt==0)
        {
            x1 = x2 = -b / (2 * a);
            Console.WriteLine("x1=x2={0}",x1);
            
        }
        else
        {
            x2 = (-b + Math.Sqrt(discriminatnt)) / (2 * a);
            x1 = (-b - Math.Sqrt(discriminatnt)) / (2 * a);

            Console.WriteLine("Roots of the quadratic equation are x1={0} x2={1}", x1, x2);
        

        }
    }
}
