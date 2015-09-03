//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
using System;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter s:");
        int s=int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int currSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempIndex = 0;
        

        for (int i = 0; i < array.Length-1; i++)
        {
            currSum = array[i];
            for (int j = i+1; j < array.Length; j++)
            {
                currSum +=   array[j];
                if (currSum>s)
                {
                    break;
                }
                else if (currSum==s)
                {
                    endIndex = j;
                    startIndex = i;
                }
            }
            
        }
        Console.WriteLine();
        Console.Write("The best sequance is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(i != (endIndex) ? "{0}, " : "{0}\n", array[i]);

        }
        
    }
}
