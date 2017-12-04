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
                foreach (string line in content)
                {
                    Console.WriteLine(line);
                }
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
