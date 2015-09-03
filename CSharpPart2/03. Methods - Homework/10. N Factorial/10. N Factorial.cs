//•	Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int[] arr = new int[100];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }

        CalculateFactorialOfN(arr);
    }

    static void CalculateFactorialOfN(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            BigInteger factorial = Factorial(array[i]);
            Console.WriteLine(factorial);
        }
    }

    
    static BigInteger Factorial(BigInteger  n)
    {

        if (n == 0) return 1;
        else return n*Factorial(n - 1);
    }
    
}
