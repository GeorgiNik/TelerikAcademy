//•	Write a program that shows the internal binary representation of given 32-bit signed 
        //  floating-point number in IEEE 754 format (the C# type float).
using System;
using System.Globalization;
using System.Text;
using System.Threading;

class BinaryFloatingPoint
{
    static string FloatToBinary(float number)
    {
        int intNumber = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
        return Convert.ToString(intNumber, 2);
    }

    static string GetExponent(string inBinary)
    {
        return inBinary.Substring(0, 8);
    }

    static string GetMantissa(string inBinary)
    {
        return inBinary.Substring(8);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter floating-point number: ");
        float number = float.Parse(Console.ReadLine());

        Console.WriteLine(FloatToBinary(number));

    }
    
}
