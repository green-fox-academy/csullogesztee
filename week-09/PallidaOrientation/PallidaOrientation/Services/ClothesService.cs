using PallidaOrientation.Models;
using PallidaOrientation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientation.Services
{
    public class ClothesService
    {
        private ClothesRepository clothesRepository;

        public ClothesService(ClothesRepository clothesRepository)
        {
            this.clothesRepository = clothesRepository;
        }

        public List<Clothes> GetTheList()
        {
            return clothesRepository.GetClothes().ToList();
        }

        public Summary CreateSummary(string name, string size, int amount)
        {
            var oneClothes = clothesRepository.GetClothes().FirstOrDefault(x => x.ItemName == name && x.Size == size);

            if (oneClothes == null) return new Summary();

            return new Summary()
            {
                ItemName = oneClothes.ItemName,
                Category = oneClothes.Category,
                Manufacturer = oneClothes.Manufacturer,
                Size = oneClothes.Size,
                Quantity = amount,
                TotalPrice = oneClothes.UnitPrize * amount
            };
        }

        public List<Clothes> SortClothes(int price, PriceType type)
        {

            switch (type)
            {
                case PriceType.Equal:
                    return clothesRepository.GetClothes().Where(x => x.UnitPrize == price).ToList();
                    break;
                case PriceType.Lower:
                    return clothesRepository.GetClothes().Where(x => x.UnitPrize  < price).ToList();
                    break;
                case PriceType.Higher:
                    return clothesRepository.GetClothes().Where(x => x.UnitPrize > price).ToList();
                    break;
                default:
                    break;
            }

            return new List<Clothes>();
        }
    }
}
