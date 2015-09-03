using System;
using System.IO;

//•	Write a program that concatenates two text files into another text file.
class ConcatenateTextFiles
{
    static void Main()
    {
        string fileOne = @"..\..\file1.txt";
        string fileTwo = @"..\..\file2.txt";

        StreamReader readOne = new StreamReader(fileOne);
        StreamReader readTwo = new StreamReader(fileTwo);

        string readFileOne = "";
        string readFileTwo = "";

        using (readOne)
        {
            readFileOne = readOne.ReadToEnd();
        }

        using (readTwo)
        {
            readFileTwo = readTwo.ReadToEnd();
        }

        StreamWriter newFile = new StreamWriter(@"..\..\New File.txt", true);

        using (newFile)
        {
            newFile.WriteLine(readFileOne);
            newFile.WriteLine(readFileTwo);
        }
        Console.WriteLine("Files are concatenated successfully");
    }
}