using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//•	Write a program that extracts from given XML file all the text without the tags.
class ExtractTextFromXML
{
    
    static readonly StringBuilder textWithoutTags = new StringBuilder();
	static void Main()
	{
		const string Path = "../../text.xml";

		ExtractTextWithoutTags(Path);

		Console.WriteLine(textWithoutTags);
	}

	static void ExtractTextWithoutTags(string pathTextFile)
	{
		using (StreamReader reader = new StreamReader(pathTextFile))
		{
			while (!reader.EndOfStream)
			{
				string line = Regex.Replace(reader.ReadLine(), @"<[^>]*>", String.Empty).Trim();
				if (line != "")
				{
					textWithoutTags.AppendLine(line);
				}
			}
		}
	}
}

