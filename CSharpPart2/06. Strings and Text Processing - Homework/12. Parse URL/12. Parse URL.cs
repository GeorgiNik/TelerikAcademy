/*•	Write a program that parses an URL address given in the format:
         * [protocol]://[server]/[resource] and extracts from it the [protocol],
         * [server] and [resource] elements.*/
using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        const string URL = @"http://telerikacademy.com/Courses/Courses/Details/212";
        //string URL= Console.ReadLine()
        var urlParts = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;

        
        Console.WriteLine("[protocol] = {0}", urlParts[1]);
        Console.WriteLine("[server] = {0}", urlParts[2]);
        Console.WriteLine("[resource] = {0}\n", urlParts[3]);
    }
}
