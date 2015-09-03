//•	Write a program to convert binary numbers to their decimal representation.
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        string number = Console.ReadLine();
        Console.WriteLine("Number in decimal numeral system:");
        Console.WriteLine(ConvertToDecimal(number));
    }
    static long ConvertToDecimal(string number)
    {
        long decimaNumber = 0;
        for (int i = 0; i < number.Length; i++)
        {
            int digit = number[i] - '0';
            int pos=number.Length-i-1;
            decimaNumber += digit * (long)Math.Pow(2,pos);
        }
        return decimaNumber;
    }
}

