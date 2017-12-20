using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        public double TotalSugar { get; set; }
        public double MoneyIncome { get; set; } = 0;
        public List<Sweets> CandyStorage = new List<Sweets>();
        private int lollipopCounter = 0;
        private int candyCounter = 0;

        public CandyShop(int grammofsugar)
        {
            TotalSugar = grammofsugar;
        }

        public void Raise(int percentage)
        {
            foreach (Sweets sweet in CandyStorage)
            {
                sweet.Price = sweet.Price * (1.0 + percentage / 100.0);
            }
        }

        public void CreateSweets(string typeOfTheSweet)
        {
            if (typeOfTheSweet == "lollipop")
            {
                CandyStorage.Add(new Lollipop());
                TotalSugar -= 5;
                lollipopCounter++;
            }
            if (typeOfTheSweet == "candy")
            {
                CandyStorage.Add(new Candy());
                TotalSugar -= 10;
                candyCounter++;
            }
        }

        public void Sell(string typeOfSweet, int howmany)
        {
            for (int i = 0; i < howmany; i++)
            {
                for (int j = 0; j < CandyStorage.Count; j++)
                {
                if (CandyStorage[j].Type == typeOfSweet)
                {
                    MoneyIncome += CandyStorage[j].Price;
                    //Console.WriteLine(CandyStorage[j].Price + typeOfSweet + CandyStorage[j].Type);
                    CandyStorage.Remove(CandyStorage[i]);
                }
                }
                if (typeOfSweet == "lollipop")
                {
                    lollipopCounter--;
                }
                if (typeOfSweet == "candy")
                {
                    candyCounter--;
                }
            }
        }

        public void BuySugar(int howmuchSugar)
        {
            int priceOfTheSugar = howmuchSugar / 10;

            if (MoneyIncome < priceOfTheSugar)
            {
                Console.WriteLine("Don't have enough money!");
            }
            else
            {
                TotalSugar += howmuchSugar;
                MoneyIncome -= priceOfTheSugar;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory: {0} candies, {1} lollipops, Income: {2}, Sugar: {3}gr", candyCounter, lollipopCounter, MoneyIncome, TotalSugar);  
        }
    }
}
