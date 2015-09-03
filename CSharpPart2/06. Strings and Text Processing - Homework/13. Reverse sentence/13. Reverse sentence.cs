//•	Write a program that reverses the words in given sentence.
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReverseSentence
{
    static void Main()
    {
        
        string text = "C# is not C++ , not PHP and not Delphi!";
        char sign = text[text.Length - 1];
        List<int> comas = new List<int>();
        
        string[] words = text.Split(new char[] { ' ', '.', '?', '!', }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == ",")
            {
                comas.Add(i);
            }
        }
        string[] wordsResult = text.Split(new char[] { ' ', '.', '?', '!', ','}, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(wordsResult);
        for (int i = 0; i < comas.Count; i++)
        {
            wordsResult[comas[i]] = ",";
        }
        var result = String.Join(" ", wordsResult);
        
        
        Console.WriteLine(result+sign);
        
    }
}

