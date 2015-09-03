using System;
class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Vavedete chislo:");
        int number =int.Parse( Console.ReadLine());
        bool odd = true;
        if (number % 2 != 0) Console.WriteLine("Is Odd?:{0}",odd);
        else
        {
            odd = false;
            Console.WriteLine("Is Odd?:{0}", odd);
        }
        
    }
}

