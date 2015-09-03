using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer Number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position p:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value v:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of the {0} is:\n{1}", n, Convert.ToString(n, 2).PadLeft(16, '0'));

        int mask = 1 << p;

        if (v == 0)
        {
            n = n & (~mask);
            Console.WriteLine("Binary result is:\n{0}\nand now has value of: {1}", Convert.ToString(n, 2).PadLeft(16, '0'), n);
        }
        else 
        {
            n = n | mask;
            Console.WriteLine("Binary result is:\n{0}\nand now has value of:\n{1}", Convert.ToString(n, 2).PadLeft(16, '0'), n);
        }
    }
}