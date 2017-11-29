using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            // Hofstadter's Law: It always takes longer than you expect, even when you take into account Hofstadter's Law.

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            // gagyi solution:
            // quote = quote.Insert(20, " always takes longer than");
            
            string firstpart = quote.Substring(0, 20);
            string addpart = " always takes longer than ";
            string lastpart = quote.Substring(21);

            var builtquote = new StringBuilder();
            builtquote.Append(firstpart);
            builtquote.Append(addpart);
            builtquote.Append(lastpart);

            Console.WriteLine(builtquote);
            Console.ReadLine();
        }
    }
}