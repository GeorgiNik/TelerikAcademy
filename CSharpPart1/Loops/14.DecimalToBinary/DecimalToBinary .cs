using System;

using System.Text;
class DecimalToBinary 
{
    static void Main()
    {
        long numberInDecimal = long.Parse(Console.ReadLine());
        long remainder;
        StringBuilder binary = new StringBuilder();
        
        while (numberInDecimal != 0)
        {
            int index = 0;
            remainder = numberInDecimal % 2;
            binary.Insert(index, remainder);

            numberInDecimal /= 2;
            index++;
            
        }
        
        
        Console.WriteLine(binary);
    }
}