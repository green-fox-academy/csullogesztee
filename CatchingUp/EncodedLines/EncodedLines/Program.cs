using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFrom = @"C:\Users\Esztee\greenfox\csullogesztee\CatchingUp\EncodedLines\EncodedLines\encoded-lines.txt";
            string pathTo = @"C:\Users\Esztee\greenfox\csullogesztee\CatchingUp\EncodedLines\EncodedLines\original-text.txt";

            string[] content = File.ReadAllLines(pathFrom);
            List<string> newContentList = new List<string>();

            for (int j = 0; j < content.Length; j++)
            {
                newContentList.Add(Decoder(content[j]));
            }
            File.WriteAllLines(pathTo, newContentList.ToArray());
        }
        static string Decoder(string content)
        {
            char[] charactersOfContent = content.ToCharArray();

            List<char> CharacterList = new List<char>();

            foreach (char character in charactersOfContent)
            {
                int place = Convert.ToInt16(character);
                place--;
                CharacterList.Add(Convert.ToChar(place));
            }

            StringBuilder builtLine = new StringBuilder();

            foreach (char character in CharacterList)
            {
                builtLine.Append(character);
            }

            return Convert.ToString(builtLine);
        }
    }
}
