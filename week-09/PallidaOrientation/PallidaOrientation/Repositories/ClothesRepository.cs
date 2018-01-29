using PallidaOrientation.Entities;
using PallidaOrientation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientation.Repositories
{
    public class ClothesRepository
    {
        private ShopContext shopContext;

        public ClothesRepository(ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }

        public IEnumerable<Clothes> GetClothes()
        {
            return shopContext.Clothes;
        }
    }
}
