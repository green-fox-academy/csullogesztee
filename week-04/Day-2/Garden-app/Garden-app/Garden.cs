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

        public int WateringFlower(int amountofwater, int waterofflower)
        {
            waterofflower = waterofflower + (amountofwater / (Flowers.Count + Trees.Count) * 75 / 100);

            return waterofflower;
        }
        public int WateringTree (int amountofwater, int wateroftree)
        {
            wateroftree = wateroftree + (amountofwater / (Flowers.Count + Trees.Count) * 40 / 100);
            
            return wateroftree;
        }
    }
}
