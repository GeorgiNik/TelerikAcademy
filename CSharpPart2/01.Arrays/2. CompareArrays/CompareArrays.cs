//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        
        Console.Write("Enter size of the first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter size of the second array: ");
        int m = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[m];
        bool isEqual = true;
        if (n == m)
        {
            Console.WriteLine("Enter {0} numbers for the first array: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("First Array[{0}] = ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter {0} numbers for the second array: ", m);
            for (int i = 0; i < m; i++)
            {
                Console.Write("Second Array[{0}] = ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] != array2[i])
                {
                    isEqual = false;
                    break;
                }
            }

        }
        else isEqual = false;
        if (isEqual)
        {
            Console.WriteLine("The two arrays are equal");
        }
        else
        {
            Console.WriteLine("The two arrrays are different");
        }
    }
}