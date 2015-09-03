//•	Write a method that reverses the digits of given decimal number.
using System;
using System.Threading;
using System.Globalization;



class ReverseNumber
{
    static string ReverseDigits(string number)
    {
        char[] charNumbers = number.ToCharArray();
        Array.Reverse(charNumbers);
        return new string(charNumbers);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter decimal to reverse:");
        string number = Console.ReadLine();
        Console.WriteLine("Reversed: {0}", ReverseDigits(number));
    }
}