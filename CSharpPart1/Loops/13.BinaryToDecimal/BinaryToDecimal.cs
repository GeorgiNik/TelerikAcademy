using System;

class BinaryToDecimal
{
    static void Main()
    {

        string input = Console.ReadLine();
        long resultDecimal = new long();
        int digit;
        int power=0;
        for (int i = input.Length-1; i>=0 ; i--)
        {
            digit =input[i]-'0'; //vzemam cifrata na poziciq i q prisvoqvam na digit
            if (digit==1)        
            {
                resultDecimal +=(long) Math.Pow(2, power);
            }
            power++;
        }
        Console.WriteLine("decimal: {0}",resultDecimal);
    }
}
