using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter Integers (given in a single line, separated by a space) :");
        string strNumbers = Console.ReadLine();
        string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < Numbers.Length; i++)
        {
            int number = int.Parse(Numbers[i]);
            if (i % 2 != 0)
            {
                oddProduct *= number;
            }
            else if(i%2==0)
            {
                evenProduct *= number;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}