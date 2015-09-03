/*•	Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
        * percentage and in scientific notation.
         •	Format the output aligned right in 15 symbols.*/
using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        Dec(number);
        Hex(number);
        Percentage(number);
        ScientificNotation(number);
    }
 
    private static void ScientificNotation(string number)
    {
        Console.WriteLine("{0,15:E}",double.Parse(number));
    }
 
    private static void Percentage(string number)
    {
        Console.WriteLine("{0,15:P}",double.Parse(number)/100);
    }
 
    private static void Hex(string number)
    {
        Console.WriteLine("{0,15:X}", int.Parse(number));
    }
 
    private static void Dec(string number)
    {
        Console.WriteLine("{0,15:D}",int.Parse(number));
    }
 
  
}

