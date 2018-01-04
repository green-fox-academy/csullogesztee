using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The 100worst.csv file contains the 100 worst singles over 25 years.
// Your task is to check which year produced the most.
// So create the necessary method(s).
// And print out the sentence below with the proper year.
//  `The year when the most worst songs came out is <year>.`

namespace WorstSong
{
    public class WorstSong
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Esztee\greenfox\csullogesztee\week-06\ReTake\WorstSongs\WorstSongs\Worst100.csv";

            Console.WriteLine("The year when the most worst songs came out is " + SearchWorstSongsYear(path));
            Console.ReadLine();
        }

        public static int SearchWorstSongsYear(string path)
        {
            string[] ourtext = File.ReadAllLines(path);

            Dictionary<int, int> years = new Dictionary<int, int>();
            
            foreach(string lines in ourtext)
            {
                string[] line = lines.Split(';');

                if(years.ContainsKey(int.Parse(line.Last())))
                {
                    years[int.Parse(line.Last())]++;
                }
                else
                {
                    years.Add(int.Parse(line.Last()), 1);
                }
            }

            int worstYear = 0;
            foreach (var year in years)
            {
                if (year.Value == years.Values.Max())
                    worstYear = year.Key;
            }

            return worstYear;
        }
    }
}