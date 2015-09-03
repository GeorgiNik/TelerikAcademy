//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.
using System;

class MergeSorting
{
    public static void MergeSort(int[] input, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(input, left, middle);
            MergeSort(input, middle + 1, right);

            //Merge
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
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
        MergeSort(array, 0, array.Length - 1);//sortiram  masiva s Merge sort
        string print = String.Join(", ", array);
        Console.WriteLine("\nSorted arrray:");
        Console.WriteLine(print);
    }
}
