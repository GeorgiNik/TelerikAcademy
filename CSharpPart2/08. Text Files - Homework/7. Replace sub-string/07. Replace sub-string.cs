using System;
using System.Collections.Generic;
using System.IO;

/*•	Write a program that replaces all occurrences of the sub-string start with 
*  the sub-string finish in a text file.
•	Ensure it will work with large files (e.g. 100 MB).*/
class ReplaceSubString
{
    static void Main()
    {
        const string Path = "../../text.txt";

        ReplaceSubstring(Path);
        Console.WriteLine("Result is in file result.txt");
    }

    private static void ReplaceSubstring(string Path)
    {
        string result;
        using(StreamReader reader=new StreamReader(Path))
        {
            string input = reader.ReadToEnd();
            result=input.Replace("start", "finish");
            
        }
        using(StreamWriter writer=new StreamWriter(@"..\..\result.txt"))
        {
            writer.Write(result);
        }
    }
    
}