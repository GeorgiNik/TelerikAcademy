//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.
using System;

class MaximalIncreacinSequence
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int bestSeq = 1;
        int currSeq = 1;
        string currNum = "";
        string bestNum = "";
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currSeq++;
                currNum += array[i] + " ";
            }
            else
            {
                if (currSeq > bestSeq)
                {
                    bestSeq = currSeq;
                    currNum += array[i] + " ";
                    bestNum = currNum;
                }
                currSeq = 1;
                currNum = "";
            }
        }
        if (currSeq > bestSeq)
        {
            currNum += array[array.Length - 1];
            bestNum = currNum;
        }
        Console.WriteLine(bestNum);
    }
}
