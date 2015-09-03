//•	Write a program that reads a string from the console and lists all different words in the 
//  string along with information how many times each word is found.
using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input=Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        var dict = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!dict.ContainsKey(word))
            {
                dict.Add(word, 1);
            }
            else
            {
                dict[word]++;
            }
        }
        foreach (var elem in dict)
        {
            Console.WriteLine("{0} {1}", elem.Key, elem.Value);
        }
    }
}

