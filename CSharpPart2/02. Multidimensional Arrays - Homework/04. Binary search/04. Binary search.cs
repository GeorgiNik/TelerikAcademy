/*•	Write a program, that reads from the console an array of N integers and an integer K, 
         * sorts the array and using the method Array.BinSearch() finds the largest number in the 
         * array which is ≤ K.*/
using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxValue = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}]= ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = 0; i < n; i++)
        {

            if (arr[i] <= k)
            {
                maxValue = arr[i];
            }
        }
        Array.BinarySearch(arr, maxValue);
        if (arr[0] > k)
        {
            Console.WriteLine("There isn't number <= K");
        }
        else
        {
            Console.WriteLine("Largest number in the array which is ≤ K is: {0}", maxValue);
        }
    }
}

