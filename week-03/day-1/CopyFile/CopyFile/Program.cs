using System;
using System.Text;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the path of the source file");
            string mypathfrom = Console.ReadLine();
            Console.WriteLine("Add the path of the target file");
            string mypathto = Console.ReadLine();

            CopyMyFile(mypathfrom, mypathto);
            Console.ReadLine();
        }
        static void CopyMyFile(string pathfrom, string pathto)
        {
            string[] content = File.ReadAllLines(pathfrom);
            
            using (StreamWriter outputfile = new StreamWriter(pathto, true))
            for (int i = 0; i < content.Length; i++)
            {
                outputfile.WriteLine(content[i]);
            }
            
        }
    }
}
