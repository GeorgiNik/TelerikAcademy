//•	Write a program that converts a string to a sequence of C# Unicode character literals.
//•	Use format strings.
using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter text:");  
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.WriteLine(GetEscapeSequence(input[i]));
        }

    }
    static string GetEscapeSequence(char c)
    {
        return "\\u" + ((int)c).ToString("X4");
    }
}

