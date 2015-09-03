using System;

class IsoscelesTriangles
{
    static void Main()
    {
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char symbol = '\u00A9';
        Console.WriteLine("    {0}", symbol);
        Console.WriteLine();
        Console.WriteLine("   {0} {0}", symbol);
        Console.WriteLine();
        Console.WriteLine("  {0}   {0}", symbol);
        Console.WriteLine();
        Console.WriteLine(" {0} {0} {0} {0}", symbol);
    }
}

