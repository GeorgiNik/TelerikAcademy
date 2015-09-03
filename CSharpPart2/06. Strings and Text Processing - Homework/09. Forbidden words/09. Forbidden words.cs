/* •	We are given a string containing a list of forbidden words and a text containing some of 
        * these words.
          •	Write a program that replaces the forbidden words with asterisks.*/
using System;

class ForbiddenWords
{
    static void Main()
    {
        string input = "Microsoft announced its next generation PHP compiler today." +
            " It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] forbiddenWords = { "Microsoft", "PHP", "CLR" };

        string[] splittedText = input.Split(new char[] { '.', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            for (int j = 0; j < splittedText.Length; j++)
            {
                if (splittedText[j] == forbiddenWords[i])
                {
                    input = input.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
                }
            }
        }

        Console.WriteLine(input);

    }
}

