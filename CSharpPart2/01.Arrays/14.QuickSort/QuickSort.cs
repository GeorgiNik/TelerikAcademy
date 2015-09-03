//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.
using System;

class QuickSort

 
{
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
 
                while (numbers[right] > pivot)
                    right--;
 
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
 
        static public void SortQuick(int[] arr, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
 
                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);
 
                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }
        }
 
        static void Main(string[] args)
        {
            
            Console.Write("Enter size of array: ");
            int max=int.Parse(Console.ReadLine());
 
            int[] numbers = new int[max];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter array[{0}]:", i);
                numbers[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("QuickSort :");
            SortQuick(numbers, 0, max - 1);
            string print = String.Join(", ", numbers);
            Console.WriteLine(print);
            
        }
    

}
