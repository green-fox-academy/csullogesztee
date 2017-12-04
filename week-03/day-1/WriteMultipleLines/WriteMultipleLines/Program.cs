using System;
using System.Text;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Add your file's path");
                string mypath = Console.ReadLine();
                Console.WriteLine("Add your word what it contains");
                string myword = Console.ReadLine();
                Console.WriteLine("Add the number of the lines");
                int mynumberoflines = int.Parse(Console.ReadLine());
                textcreator(mypath, myword, mynumberoflines);
            }
            catch
            { }
            finally
            {
                Console.ReadLine();
            }
        }
        static void textcreator(string path, string word, int numberoflines)
        {
            using (StreamWriter outputfile = new StreamWriter(path, true))
                for (int i = 0; i < numberoflines - 1; i++)
                {
                    outputfile.WriteLine(word);
                }
            
        }
    }
}
