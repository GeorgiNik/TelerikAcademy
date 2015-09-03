using System;
using System.Linq;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Random rnd = new System.Random();
        var numbers = Enumerable.Range(1, n).OrderBy(r => rnd.Next()).ToArray();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine();
    }
}