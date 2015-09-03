//•	Write a program to convert decimal numbers to their binary representation.
using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        long  decimalNumber=long.Parse(Console.ReadLine());
        Console.WriteLine("Number in binary:");
        Console.WriteLine(ConvertToBinary( decimalNumber));
    }
    static string ConvertToBinary(long decimalNumber)
    {
        string binaryNumber = null;
        while(decimalNumber>0)
        {
            var digit = decimalNumber % 2;
            binaryNumber += digit;
            decimalNumber /= 2;
        }
        var numberToChar = binaryNumber.ToCharArray();
        Array.Reverse(numberToChar);
        binaryNumber = new string(numberToChar);
        return binaryNumber;
    }
}
