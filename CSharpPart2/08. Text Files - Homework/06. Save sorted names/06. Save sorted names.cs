using System;
using System.Collections.Generic;
using System.IO;

//•	Write a program that reads a text file containing a list of strings, sorts them
//  and saves them to another text file.
class SaveSortedNames
{
    static void Main()
    {
        const string Path = "../../text.txt";

        SortFile(Path);
        Console.WriteLine("Result is in file result.txt");
    }

    private static void SortFile(string Path)
    {
        List<string> input = new List<string>();
        using (StreamReader reader = new StreamReader(Path))
        {
            string lineRead = reader.ReadLine();
            while (lineRead != null)
            {
                input.Add(lineRead);
                lineRead = reader.ReadLine();
            }
            input.Sort();
        }
        using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
        {
            foreach (var line in input)
            {
                writer.WriteLine(line);
            }
        }
    }
}