using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            var myorderedList = OrderDominoes(dominoes);

            Console.WriteLine("Play domino:");
            foreach (Domino item in myorderedList)
            {
                Console.WriteLine("[" + item.GetValues()[0] + " , " + item.GetValues()[1] + "]");
            }

            dominoes.Sort();
            Console.WriteLine("Sort of the dominoes:");
            foreach (Domino item in dominoes)
            {
                Console.WriteLine("[" + item.GetValues()[0] + " , " + item.GetValues()[1] + "]");
            }

            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }

        public static List<Domino> OrderDominoes( List<Domino> mylistofdominoes)
        {
            var orderedList = new List<Domino>();

            orderedList.Add(mylistofdominoes[0]);

            for (int i = 1; i < mylistofdominoes.Count; i++)
            { 

                for (int j = 0; j < mylistofdominoes.Count; j++)
                {
                    if (orderedList[i - 1].GetValues()[1] == mylistofdominoes[j].GetValues()[0])
                    {
                        orderedList.Add(mylistofdominoes[j]);
                        
                    }
                }
            
            }
            return orderedList;
        }
    }
}