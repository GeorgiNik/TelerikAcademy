//•	Write a program to convert decimal numbers to their hexadecimal representation.
using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Number in hex numeral system:");
        Console.WriteLine(DecimalToHex(number));
    }
    static string DecimalToHex(long decimalNumber)
    {
        string hex = null;
        while (decimalNumber>0)
        {
            long digit = decimalNumber % 16;
            if (digit>=0&&digit<=9)
            {

                hex = (char)(digit + '0') + hex;
                
            }
            else if (digit >= 10 && digit <= 15)
            {
                hex = (char)(digit - 10 + 'A') + hex;
                
            }
            decimalNumber /= 16;
        }
        return hex;
    }
}

