//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;

class IndexOfLetters
{
    static void Main()
    {
        
        char[] letters = new char[26];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = Convert.ToChar((int)'a' + i);            
        }
        Console.WriteLine("Enter word :");
        string word = Console.ReadLine();
        Console.WriteLine("Indexs of word letters:");
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write(Array.IndexOf(letters,word[i])+" ");
        }
        Console.WriteLine();
      
    }
}
