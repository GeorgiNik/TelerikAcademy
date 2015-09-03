//•	Write a program that reads a list of words, separated by spaces 
//  and prints the list in an alphabetical order.
using System;
using System.Linq;
class OrderWords
{
    static void Main()
    {
        Console.WriteLine("enter words separated by space:");
        string input = Console.ReadLine();
        var splitted = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(splitted);
        var result = string.Join(" ", splitted);
        Console.WriteLine(result);
        
    }
}
