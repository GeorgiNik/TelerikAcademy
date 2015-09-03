//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;
using System.Collections.Generic;
class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter array size:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the element to be searched:");
        int element=int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int index;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter array[{0}]:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        index = Array.BinarySearch(array, element);// tozi metod mi vrashta indexa na tarseniq element v masiva array ,posredstvom Binary Search
        Console.WriteLine("The index of the searched element is : {0}",index);
    }
}
