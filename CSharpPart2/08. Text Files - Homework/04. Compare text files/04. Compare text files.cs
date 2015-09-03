using System;
using System.IO;
class CompareTextFiles
{
   static int sameLinesCount = 0, diffLinesCount = 0;

	static void Main()
	{
		const string firstPath = "../../text1.txt";
		const string secondPath = "../../text2.txt";

		CompareFiles(firstPath, secondPath);

		Console.WriteLine("Same lines: {0}", sameLinesCount);
		Console.WriteLine("Different lines: {0}\n", diffLinesCount);
	}

	static void CompareFiles(string pathText1, string pathText2)
	{
		using (StreamReader reader1 = new StreamReader(pathText1))
		{
			using (StreamReader reader2 = new StreamReader(pathText2))
			{
				
				while (!reader1.EndOfStream || !reader2.EndOfStream)
				{
					string line1 = reader1.ReadLine();
					string line2 = reader2.ReadLine();

					if (String.Compare(line1, line2, StringComparison.Ordinal) == 0) sameLinesCount++;
					else diffLinesCount++;
				}
			}
		}
	}
}

