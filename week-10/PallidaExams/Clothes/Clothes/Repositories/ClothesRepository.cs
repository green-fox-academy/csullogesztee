using ClothesMarket.Entities;
using ClothesMarket.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClothesMarket.Repositories
{
    public class ClothesRepository
    {
        private ClothesContext clothesConext;

        public ClothesRepository(ClothesContext clothesConext)
        {
            this.clothesConext = clothesConext;
        }

        public List<Clothes> AllClothes()
        {
            return clothesConext.Warehouse.ToList();
        }

        public Clothes ClothesFromName(string name, string size)
        {
            return clothesConext.Warehouse.FirstOrDefault(x => x.ItemName.Equals(name) && x.Size.Equals(size));
        }
    }
}
