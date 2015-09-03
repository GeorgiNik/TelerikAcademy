//•	Write a program that extracts from a given text all sentences containing given word.
using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string keyWord = "in";

        string[] splitted = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        
        string[] result;
        foreach (var sentence in splitted)
        {
            if (sentence.Contains(" in ") || sentence.Contains("in ") || sentence.Contains(" in")) 
            {
                Console.Write(sentence.Trim() + ".");
            }
        }
        Console.WriteLine();
    }
}

