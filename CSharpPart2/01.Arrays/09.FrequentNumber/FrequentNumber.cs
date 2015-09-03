//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
using System;
using System.Collections.Generic;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
              
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
            
        }
        int mostFrequent = 0;
        int mostCount = 1;

        for (int i = 0; i < array.Length; i++)
        {
            int currentCount = 1;

            for (int j = 0; j < array.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }
                else
                {
                    if (array[i] == array[j])
                    {
                        currentCount++;
                    }
                }
            }

            if (currentCount > mostCount)
            {
                mostCount = currentCount;
                mostFrequent = array[i];
            }
        }

        Console.WriteLine("{0} ({1} times)",mostFrequent,mostCount);
    }
        
    
}
