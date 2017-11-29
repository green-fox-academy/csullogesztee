using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Reverser(reversed);

            Console.WriteLine(reversed);
            Console.ReadLine();
        }
        public static void Reverser(string reversedstring)
            {
            int lastindex = reversedstring.Length;
            string first = reversedstring.Substring(0);
            string last = reversedstring.Substring(lastindex);

            for (int i = 0 ; i < (reversedstring.Length / 2); i++);
            {
                for (int j = 1; j < (reversedstring.Length / 2); j++)
                { 
                  first = reversedstring.Substring(j);
                  int extra = lastindex - j;
                  last = reversedstring.Substring(extra);
                        
                }
                string newstring = first;
                first = last;
                last = newstring;
            }
        }
    }
}