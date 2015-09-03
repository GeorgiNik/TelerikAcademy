/*•	Write a method GetMax() with two parameters that returns the larger of two integers.
          •	Write a program that reads 3 integers from the console and prints the largest of 
         * them using the method GetMax(). */
using System;

class GetLargestNumber
{
    static int GetMax(int par1,int par2)
    {
        if (par1 > par2) return par1;
        else return par2;
    }
    static void Main()
    {
        int maxPar = int.MinValue;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("enter {0} parametar:",i);
            int par=int.Parse(Console.ReadLine());
            maxPar = GetMax(maxPar, par);
        }
        Console.WriteLine("Maximal parametar of the three is : {0}",maxPar);
        


        

    }
}

