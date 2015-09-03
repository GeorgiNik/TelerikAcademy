//•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
using System;

class Palindromes
{
    public static bool IsPalindrome(string value)
    {
        int min = 0;
        int max = value.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = value[min];
            char b = value[max];
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            min++;
            max--;
        }
    }
    static void Main()
    {
        Console.WriteLine("enter text:");
        string text = Console.ReadLine();
        string[] splitted = text.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in splitted)
        {
            if (IsPalindrome(word))
            {
                Console.WriteLine(word);
            }
        }


    }
}
