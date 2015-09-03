using System;

class BigestNumber
{
    static void Main()
    {
        double biggest = double.MinValue;
        double current;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Enter the {0} number", i);
            current = double.Parse(Console.ReadLine());
            if (current > biggest)
            {
                biggest = current;
            }
        }
        Console.WriteLine("The biggest number is: {0}", biggest);

    }
}
