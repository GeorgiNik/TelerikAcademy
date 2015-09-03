//•	Write a program that extracts from given HTML file its title (if available), 
//  and its body text without the HTML tags.

using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        string text = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a> aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        int indexStart;
        int indexEnd;
        string title = null;
        var match = Regex.Match(text, "<title.*?>");
        if (match.Success)
        {
            indexStart = text.IndexOf("<title>");
            indexEnd = text.IndexOf("</title>");
            title = text.Substring(indexStart + 7, (indexEnd - (indexStart + 7)));
        }
        indexStart = text.IndexOf("<body>");
        indexEnd = text.IndexOf("</body>");
        string body = text.Substring(indexStart + 6, (indexEnd - (indexStart + 6)));
        body = Regex.Replace(body, "<.*?>", string.Empty);
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Body: {0}", body);
        
        //Variant 2
        //Console.WriteLine("Enter html text: ");
        //string text = Console.ReadLine();
        //foreach (Match item in Regex.Matches(text, "(?<=^|>)[^><]+?(?=<|$)"))
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine();

        
    }
 

}