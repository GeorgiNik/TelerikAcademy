//• Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
using System;
using System.Text.RegularExpressions;

class SubStringInText
{
    static void Main()
    {
        Console.WriteLine("The target sub-string is:");
        string toMatch = Console.ReadLine();
        Console.WriteLine("Enter the text:");
        string input = Console.ReadLine();
        
        int count = Regex.Matches(input, toMatch).Count;
        Console.WriteLine(count);
    }
}

