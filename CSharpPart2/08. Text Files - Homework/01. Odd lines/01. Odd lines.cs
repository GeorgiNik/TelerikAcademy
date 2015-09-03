using System;
using System.IO;

//•	Write a program that reads a text file and prints on the console its odd lines.
class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\oddLines.txt");
        int countLine = 0;
        string lineRead = reader.ReadLine();

        while (lineRead != null)
        {
            countLine++;

            if (countLine % 2 != 0)
            {
                Console.WriteLine(lineRead);
            }

            lineRead = reader.ReadLine();
        }
        reader.Close();
    }
}