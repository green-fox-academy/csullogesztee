using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"my/file.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content[0]);
            }
            catch
            {
                Console.WriteLine("Unable to read file: my - file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
