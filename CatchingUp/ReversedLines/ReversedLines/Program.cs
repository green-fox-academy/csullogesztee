using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFrom = @"C:\Users\Esztee\greenfox\csullogesztee\CatchingUp\ReversedLines\ReversedLines\reversed-lines.txt";
            string pathTo = @"C:\Users\Esztee\greenfox\csullogesztee\CatchingUp\ReversedLines\ReversedLines\original-text.txt";

            string[] content = File.ReadAllLines(pathFrom);
            List<string> newContentList = new List<string>();

            for (int j = 0; j < content.Length; j++)
            {
                newContentList.Add(Examiner(content[j]));
            }
            File.WriteAllLines(pathTo, newContentList.ToArray());
        }
        static string Examiner(string content)
        {
            char[] charactersOfContent = content.ToCharArray();

            StringBuilder builtLine = new StringBuilder();

            foreach (char character in charactersOfContent.Reverse())
            {
                builtLine.Append(character);
            }

            return Convert.ToString(builtLine);
        }
    }
}
