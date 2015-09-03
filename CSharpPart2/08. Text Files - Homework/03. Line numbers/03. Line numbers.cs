using System;
using System.IO;

//•	Write a program that reads a text file and inserts line numbers in front of each of its lines.
//•	The result should be written to another text file.
class LineNumbers
{
    static void Main()
    {
        StreamReader reader =new StreamReader(@"..\..\somefile.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}",
                    lineNumber, line);
                line = reader.ReadLine();
            }
        }
        
    }
}