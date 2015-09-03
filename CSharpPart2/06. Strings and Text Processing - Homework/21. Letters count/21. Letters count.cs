//•	Write a program that reads a string from the console and prints all different letters in the 
//  string along with information how many times each letter is found.
using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        char[] letters = Console.ReadLine().ToCharArray();

        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var letter in letters)
        {
            if (!dict.ContainsKey(letter))
            {
                dict.Add(letter, 1);
            }
            else
            {
                dict[letter]++;
            }
        }
        foreach (var elem in dict)
        {
            Console.WriteLine("{0} {1}", elem.Key, elem.Value);
        }
    }
}

