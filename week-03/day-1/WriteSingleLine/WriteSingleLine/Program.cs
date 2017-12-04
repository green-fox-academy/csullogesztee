using System;
using System.Text;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = "Csullog Eszter";
                File.WriteAllText("My-file.txt", name);
            }
            catch
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
