using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object dominoes)
        {
            int result = 0;

            Domino comparedDominoes = dominoes as Domino;

            if (comparedDominoes.Values[0] < Values[0])
            {
                result = 1;
            }
            else if (comparedDominoes.Values[0] > Values[0])
            {
                result = -1;
            }
            else
            {
                if (comparedDominoes.Values[1] < Values[1])
                {
                    result = 1;
                }
                else if (comparedDominoes.Values[1] > Values[1])
                {
                    result = -1;
                }
                else
                {
                    result = 0;
                }
            }
            return result;
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}