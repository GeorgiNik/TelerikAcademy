//•	Write a program to convert hexadecimal numbers to their decimal representation.
using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number in hex:");
        string hex = Console.ReadLine();
        Console.WriteLine("Number in decimal numeral system:");
        Console.WriteLine(HexToDecimal(hex));
    }
    static long HexToDecimal(string hex)
    {
        long decimalNumber = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            int digit = 0;
            if (hex[i]>='0'&&hex[i]<='9')
            {
                digit = hex[i] - '0';
            }
            else if (hex[i] >= 'A' && hex[i] <= 'F')
            {
                digit = hex[i] - 'A' + 10;

            }
            decimalNumber += digit * (long)Math.Pow(16, hex.Length - i - 1);

        }
        return decimalNumber;
    }
}

