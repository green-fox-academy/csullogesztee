using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_app
{
    class Garden
    {
        private List<Flower> flowers = new List<Flower>();
        private List<Tree> trees = new List<Tree>();

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

        public void Watering(int amountofwater, int waterofflower, int wateroftree)
        {
            waterofflower = waterofflower + (amountofwater / (Flowers.Count + Trees.Count) * 75 / 100);
            wateroftree = wateroftree + (amountofwater / (Flowers.Count + Trees.Count) * 40 / 100);

            //return waterofflower;
            //return wateroftree;
        }
    }
}
