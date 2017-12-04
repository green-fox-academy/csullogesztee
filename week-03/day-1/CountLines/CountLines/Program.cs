using System;
using System.Text;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Add a filename!");
                string myfile = Console.ReadLine();
                LineCounter(myfile);

            }
            catch
            {
                Console.WriteLine("0");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static void LineCounter(string filename)
        {
            string[] linesoffilename = File.ReadAllLines(filename);
            int numberoflines = linesoffilename.Length;
            Console.WriteLine(numberoflines);
        }
    }
}
