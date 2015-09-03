using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your birthday (dd.MM.yyyy): ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int currentAge = DateTime.Today.Year - birthday.Year;
        if (DateTime.Today.Month < birthday.Month)
        {
            currentAge = currentAge - 1;
        }

        Console.WriteLine("Your current age: {0}", currentAge);
        Console.WriteLine("Your age after ten years: {0}", currentAge + 10);
    }
}

