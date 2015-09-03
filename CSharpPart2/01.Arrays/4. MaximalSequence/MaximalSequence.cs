//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int curCount;
        int maxCount = 0,value = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter array[{0}]:",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            curCount = 1;
            for (int j = i + 1; j < array.Length - 1;j++)
            {
                if (array[i] == array[j])
                    curCount++;
                else
                {
                    break;
                }
            }
            if (curCount > maxCount)
            {
                maxCount = curCount;
                value = array[i];
                
            }
            
        }
        Console.WriteLine("Maximal sequence of equal elements:");
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(i != (maxCount - 1) ? "{0}, " : "{0}\n", value);
        }
    }
}