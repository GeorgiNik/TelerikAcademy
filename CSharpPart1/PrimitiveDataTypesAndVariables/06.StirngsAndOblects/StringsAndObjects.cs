using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";

        object obj = hello + " " + world;
        Console.WriteLine("The object variable : {0}", obj);

        string str = (string)(obj);
        Console.WriteLine("The string variable : {0}", str);
    }
}