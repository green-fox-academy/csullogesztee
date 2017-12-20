using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    public class FavouriteAnimals
    {
        //public string path = @"C:\Users\Esztee\greenfox\csullogesztee\PallidaExam\FavouriteAnimals\FavouriteAnimals\bin\Debug\favourites.txt";

        public static void Main(string[] args)
        {
            // The program's aim is to collect your favourite animals and store them in a text file.
            // There is a given text file called '''favourites.txt''', it will contain the animals
            // If ran from the command line without arguments
            // It should print out the usage:
            // ```C# FavouriteAnimals [animal] [animal]```
            // You can add as many command line arguments as many favourite you have.
            // One animal should be stored only at once
            // Each animal should be written in separate lines
            // The program should only save animals, no need to print them

            if (args.Length == 0)
            {
                foreach (string line in CreateListFromFile(TextReader()))
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (ListChecker(CreateListFromFile(TextReader()), args[i]))
                    {
                        continue;
                    }
                    else
                    {
                        List<string> currentElementOfFile = CreateListFromFile(TextReader());
                        AddElementToList(currentElementOfFile, args[i]);
                        TextCreator(currentElementOfFile);
                    }
                }
            }
        }

        public static List<string> CreateListFromFile(string[] textFromFile)
        {
            List<string> ListFromFile = new List<string>();
            foreach (string element in textFromFile)
            {
                ListFromFile.Add(element);
            }

            return ListFromFile;
        }

        public static bool ListChecker(List<string> listfromfile, string linefromlistfromconsol)
        {
            bool isitcontain = true;
            for (int i = 0; i < listfromfile.Count; i++)
            {
                if (listfromfile.Contains(linefromlistfromconsol))
                {
                    isitcontain = true;
                }
                else
                {
                    isitcontain = false;
                }
            }
            return isitcontain;
        }

        public static void AddElementToList(List<string> listfromfile, string line)
        {

            
                listfromfile.Add(line);
            
        }

        public static string[] TextReader()
        {
            string[] contentOfFile = File.ReadAllLines(@"C:\Users\Esztee\greenfox\csullogesztee\PallidaExam\FavouriteAnimals\FavouriteAnimals\bin\Debug\favourites.txt");

            return contentOfFile;
        }

        public static void TextCreator(List<string> addedList)
        {

            int counter = TextReader().Length;
            using (StreamWriter outputfile = new StreamWriter(@"C:\Users\Esztee\greenfox\csullogesztee\PallidaExam\FavouriteAnimals\FavouriteAnimals\bin\Debug\favourites.txt"))
                foreach (string line in addedList)
                {
                    outputfile.WriteLine(line);
                }
        }
    }
}
