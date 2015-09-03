using System;
using System.Collections.Generic;
using System.IO;

//•	Write a program that deletes from given text file all odd lines.
        //•	The result should be in the same file.
class DeleteOddLines
{
    private const string Path = "../../text.txt";
	static void Main()
	{
		WriteOddLines(ReadOddLines());
	}

	static List<string> ReadOddLines()
	{
		List<string> oddLines = new List<string>();
		int lineCount = 1;

		using (StreamReader reader = new StreamReader(Path))
		{
			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine();
				if (lineCount++ % 2 == 0) oddLines.Add(line);
			}
		}

		return oddLines;
	}

	static void WriteOddLines(List<string> oddLines)
	{
		using (StreamWriter result = new StreamWriter(Path))
		{
			foreach (string t in oddLines)
			{
				result.WriteLine(t);
			}
		}
	}
}

