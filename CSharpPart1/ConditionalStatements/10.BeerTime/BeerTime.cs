using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter a time in format hh:mm tt");
        string input = Console.ReadLine();
        DateTime time;
        DateTime start = DateTime.Parse("1:00 PM");
        DateTime end = DateTime.Parse("3:00 AM");

        bool parsed = DateTime.TryParse(input, out time);
        if (parsed)
        {
            if (time >= start || time < end)
            {
                Console.WriteLine("Beer Time");
            }
            else
            {
                Console.WriteLine("Non beer Time");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
