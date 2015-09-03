using System;
using System.IO;
using System.Text.RegularExpressions;

//•	Modify the solution of the previous problem to replace only whole words (not strings).
class ReplaceWholeWord
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
        using (StreamReader reader = new StreamReader(Path))
        {
            string input = reader.ReadToEnd();
           
            string pattern = @"\bstart\b";
            string replace = "finish";
            result = Regex.Replace(input, pattern, replace);
        }
        using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
        {
            writer.Write(result);
        }
    }
}