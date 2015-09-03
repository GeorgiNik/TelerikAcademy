//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        int [] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int min;
        int temp = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            min = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    min = j;
                }
            }

            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
        Console.WriteLine("\nSorted array:");
        string print = String.Join(", ", array);
        Console.WriteLine(print);
    }
}