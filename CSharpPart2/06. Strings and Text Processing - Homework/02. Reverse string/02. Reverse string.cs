//•	Write a program that reads a string, reverses it and prints the result at the console.
using System;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] reverse=input.ToCharArray();
        Array.Reverse(reverse);
        
        Console.WriteLine(new string(reverse));
    }
}
