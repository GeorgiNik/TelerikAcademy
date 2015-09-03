using System;
using System.Globalization;
/*•	Write a program that reads a date and time given in the format:
        * day.month.year hour:minute:second and prints the date and time 
        * after 6 hours and 30 minutes (in the same format) along with the 
        * day of week in Bulgarian.*/
class DateInBulgarian
{
    static void Main()
    {

        string time = Console.ReadLine();// "20.01.2014 07:00:00";
        DateTime date = DateTime.ParseExact(time, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        switch (date.DayOfWeek.ToString())
        {
            case "Sunday": Console.WriteLine("Неделя"); break;
            case "Monday": Console.WriteLine("Понеделник"); break;
            case "Tuesday": Console.WriteLine("Вторник"); break;
            case "Wednessday": Console.WriteLine("Сряда"); break;
            case "Thursday": Console.WriteLine("Четвъртък"); break;
            case "Friday": Console.WriteLine("Петък"); break;
            case "Saturday": Console.WriteLine("Събота"); break;
        }
        Console.WriteLine("{0} ", date);
     
    }
}
