using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app
{
    class Garden
    {
        public List<Flower> flowers = new List<Flower>();
        public List<Tree> trees = new List<Tree>();

        public List<Flower> Flowers
        {
            get
            {
                return flowers;
            }
            set
            {
                flowers = value;
            }
        }
        public List<Tree> Trees
        {
            get
            {
                return trees;
            }
            set
            {
                trees = value;
            }
        }

        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }

        public void AddTree(Tree tree)
        {
            Trees.Add(tree);
        }

        public void WateringFlower(int amountofwater, Flower flower)
        {
            flower.WaterAmountFlower = flower.WaterAmountFlower + (amountofwater / (Flowers.Count + Trees.Count) * 75 / 100);

            //return waterofflower;
        }
        public void WateringTree (int amountofwater, Tree tree)
        {
            tree.WaterAmountTree = tree.WaterAmountTree + (amountofwater / (Flowers.Count + Trees.Count) * 40 / 100);
            
            //return wateroftree;
        }
    }
}
