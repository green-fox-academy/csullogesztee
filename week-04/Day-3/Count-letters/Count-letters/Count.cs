using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_letters
{
    public class Count
    {
        public static Dictionary<char, int> LetterCounter(string text)
        {
            int counter = 1;
            char[] Letters = text.ToCharArray();
            Dictionary<char, int> NumbersOfLetters = new Dictionary<char, int>();
            

            for (int i = 0; i < Letters.Length; i++)
            {
                if (NumbersOfLetters.ContainsKey(Letters[i]))
                {
                    NumbersOfLetters[Letters[i]] +=1;
                }
                else
                {
                    NumbersOfLetters.Add(Letters[i], counter);
                }

            }
            return NumbersOfLetters;

        }
    }
}
