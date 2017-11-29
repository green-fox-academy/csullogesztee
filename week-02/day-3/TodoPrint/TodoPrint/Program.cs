
using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            string beginning = "My todo:";
            string secondpoint = " - Download games";
            string lastpoint = " - Diablo";

            var builtstring = new StringBuilder();
            builtstring.Append(beginning);
            builtstring.Append("\n");
            builtstring.Append(todoText);
            builtstring.Append(secondpoint);
            builtstring.Append("\n");
            builtstring.Append("    ");
            builtstring.Append(lastpoint);

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(builtstring);
            Console.ReadLine();
        }
    }
}