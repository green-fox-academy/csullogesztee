using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFrom = @"C:\Users\Esztee\greenfox\csullogesztee\week-03\day-1\Doubled\Doubled\duplicated-chars.txt";
            string pathTo = @"C:\Users\Esztee\greenfox\csullogesztee\week-03\day-1\Doubled\Doubled\single-chars.txt";

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

            List<char> SelectedContent = new List<char>();

            for(int i = 0; i < charactersOfContent.Length; i = i + 2)
            {
                SelectedContent.Add(charactersOfContent[i]);
            }

            StringBuilder newContent = new StringBuilder();

            foreach (char element in SelectedContent)
            {
                newContent.Append(element);
            }
            return Convert.ToString(newContent);
        }
    }
}
