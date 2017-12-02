using System;
using System.Collections.Generic;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Print "true" if it contains all, otherwise print "false"
            // Can you do both the different approaches you tried in the previous one?

            var examinelist = new List<int> {4, 8, 12, 16};
            bool result = true;

            for (int i = 0; i < examinelist.Count; i++)
            {
                if (list.Contains(examinelist[i]))
                { 
                    result = true;
                }
                else
                {
                    result = false;
                    i = examinelist.Count - 1;
                }
            }
            
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}