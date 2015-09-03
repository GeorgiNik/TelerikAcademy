using System;

class MoonGravitation
{
    static void Main()
    {
        Console.WriteLine("Enter your weight:");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 0.17;
        Console.WriteLine("Weight on the Moon:{0}", moonWeight);
    }
}
