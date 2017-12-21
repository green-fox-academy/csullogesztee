using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    class Counter
    {
        public int MyNumber { get; set; }

        public Counter()
        {
            MyNumber = 0;
        }

        public int AddOne()
        {
            return MyNumber++;
        }

        public int AddNumber(int number)
        {
            return MyNumber += number;
        }

        public string GetNumber()
        {
            return Convert.ToString(MyNumber);
        }

        public void Reset()
        {
            MyNumber = 0;
        }
    }
}
