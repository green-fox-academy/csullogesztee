using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int originalNumber = random.Next(1000, 10000);
            char[] examined = Convert.ToString(originalNumber).ToCharArray();
            char[] yournumber;
            int lineCounter = 0;

            string result = "[cow][cow][cow][cow]";

            do
            {
                Console.WriteLine("Add your four-digit solution!");
                yournumber = Console.ReadLine().ToCharArray();
                lineCounter++;

                Console.WriteLine(lineCounter + ". " + GameLogic(examined, yournumber));
            }
            while (GameLogic(examined, yournumber) != result);

            Console.ReadLine();

        }

        public static string GameLogic(char[] NumberOfComputer, char[] NumberOfPlayer)
        {
            string first = "";
            string second = "";
            string third = "";
            string fourth = "";

            List<char> NumberOfComputerList = new List<char>();
            foreach (char number in NumberOfComputer)
            {
                NumberOfComputerList.Add(number);
            }

            for (int i = 0; i < NumberOfComputer.Length; i++)
            {
                if (i == 0)
                {
                    if (NumberOfComputerList.Contains(NumberOfPlayer[i]))
                    {
                        if (NumberOfPlayer[i] == NumberOfComputer[i])
                        {
                            first = "[cow]";
                        }
                        else
                        {
                            first = "[bull]";
                        }
                        NumberOfComputerList.Remove(NumberOfPlayer[i]);
                    }
                    else
                    {
                        first = "[ ]";
                    }
                }
                if (i == 1)
                {
                    if (NumberOfComputerList.Contains(NumberOfPlayer[i]))
                    {
                        if (NumberOfPlayer[i] == NumberOfComputer[i])
                        {
                            second = "[cow]";
                        }
                        else
                        {
                            second = "[bull]";
                        }
                        NumberOfComputerList.Remove(NumberOfPlayer[i]);
                    }
                    else
                    {
                        second = "[ ]";
                    }
                }
                if (i == 2)
                {
                    if (NumberOfComputerList.Contains(NumberOfPlayer[i]))
                    {
                        if (NumberOfPlayer[i] == NumberOfComputer[i])
                        {
                            third = "[cow]";
                        }
                        else
                        {
                            third = "[bull]";
                        }
                        NumberOfComputerList.Remove(NumberOfPlayer[i]);
                    }
                    else
                    {
                        third = "[ ]";
                    }
                }
                if (i == 3)
                {
                    if (NumberOfComputerList.Contains(NumberOfPlayer[i]))
                    {
                        if (NumberOfPlayer[i] == NumberOfComputer[i])
                        {
                            fourth = "[cow]";
                        }
                        else
                        {
                            fourth = "[bull]";
                        }
                        NumberOfComputerList.Remove(NumberOfPlayer[i]);
                    }
                    else
                    {
                        fourth = "[ ]";
                    }
                }
            }

            StringBuilder currentline = new StringBuilder();
            currentline.Append(first);
            currentline.Append(second);
            currentline.Append(third);
            currentline.Append(fourth);


            return Convert.ToString(currentline);
        }
    }
}
