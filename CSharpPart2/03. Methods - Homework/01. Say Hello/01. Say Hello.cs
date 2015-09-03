//•	Write a method that asks the user for his name and prints “Hello, <name>”
//•	Write a program to test this method.
using System;

class SayHello
{
    static void Name()
    {
        Console.WriteLine("Whats your name:");
        string Name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Hello ,{0}!",Name);
    }
    static void Main()
    {

        Name();
    }
}
