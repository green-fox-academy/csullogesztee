using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app2
{
    class Garden
    {
        private List<Plant> m_plants = new List<Plant>();

        public List<Plant> Plants
        {
            get { return m_plants; }
            set { m_plants = value; }
        }

        public void WriteOutState()
        {
            foreach (var plant in Plants)
            {

                //string currentPlantType = string.Empty;
                string currentPlantNeedWater = string.Empty;

                //if (plant is Tree)
                //{
                //    currentPlantType = "tree";
                //}
                //else
                //{
                //    currentPlantType = "flower";
                //}

                if (plant.NeedsWater)
                {
                    currentPlantNeedWater = " needs";
                }
                else
                {
                    currentPlantNeedWater = " doesn't need";
                }

                Console.WriteLine("The " + plant.Color + " " + plant.ToString() + currentPlantNeedWater + " water.");
            }
        }

        public void Watering(double amount)
        {
            Console.WriteLine("Watering with: " + amount);

            double amountPerPlant = amount / Plants.Count;

            foreach (var plant in Plants)
            {
                plant.Watering(amountPerPlant);
            }
        }
    }
}
