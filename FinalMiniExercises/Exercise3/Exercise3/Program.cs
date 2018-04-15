using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        //Create a function that determines if a string is a palindrome
        static void Main(string[] args)
        {
            Console.WriteLine("Add your word!");
            string myString = Console.ReadLine();

            Console.WriteLine("Your word is a palindrome: " + IsThisPalindrome(myString));

            Console.ReadKey();
        }

        static bool IsThisPalindrome(string palindrome)
        {
            bool thisIsPalindrome = true;

            for(int i = 0; i < palindrome.Length; i++)
            {
                if(palindrome[i] != palindrome[palindrome.Length - i -1])
                {
                    thisIsPalindrome = false;
                }
            }
            return thisIsPalindrome;
        }
    }
}
