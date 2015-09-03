/*•	Write a program that reads from the console a string of maximum 20 characters. If the 
        * length of the string is less than 20, the rest of the characters should be filled with *.
         •	Print the result string into the console.*/
using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        
        if(input.Length<20)
        {
            int difference = 20 - input.Length;
            result.Append(input);
            result.Append(new string('*', difference));
            
            
        }
        Console.WriteLine(result.ToString());

    }
}
