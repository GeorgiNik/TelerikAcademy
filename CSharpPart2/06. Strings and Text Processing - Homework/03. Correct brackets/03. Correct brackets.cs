//•	Write a program to check if in a given expression the brackets are put correctly.
using System;
using System.Collections.Generic;

class CorrectBrackets
{
    const char LeftParenthesis = '(';
    const char RightParenthesis = ')';
    static bool AreParenthesesBalanced(string str)
    {
        var items = new Stack<int>(str.Length);
        
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c == LeftParenthesis)
                items.Push(i);
            else if (c == RightParenthesis)
            {
                if (items.Count == 0)
                {
                    
                    return false;
                }
                items.Pop();
            }
        }
        if (items.Count > 0)
        {
            return false;
        }
        return true;
    }
    static void Main()
    {
        Console.WriteLine("Enter expression:");
        string input = Console.ReadLine();
        
        Console.WriteLine("Correct brackets:{0}", AreParenthesesBalanced(input));

    }
}

