using ClothesMarket.Models;
using ClothesMarket.Repositories;
using ClothesMarket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesMarket.Services
{
    public class ClothesService
    {
        private ClothesRepository clothesRepository;

        public ClothesService(ClothesRepository clothesRepository)
        {
            this.clothesRepository = clothesRepository;
        }

        public List<Clothes> ListAllClothes()
        {
            return clothesRepository.AllClothes();
        }

        public List<string> Sizes()
        {
            return clothesRepository.AllClothes().Select(x => x.Size).Distinct().OrderBy(x => x).ToList();
        }

        public List<string> ItemNames()
        {
            return clothesRepository.AllClothes().Select(x => x.ItemName).Distinct().OrderBy(x => x).ToList();
        }

        public ClothesViewModel GenerateViewModel()
        {
            ClothesViewModel clothesViewModel = new ClothesViewModel
            {
                Sizes = Sizes(),
                ItemNames = ItemNames(),
                Clothes = ListAllClothes()
            };
            return clothesViewModel;
        }

        public List<Clothes> SearchWithSize(double price, string type)
        {
            List<Clothes> FilteredList = new List<Clothes>();
            if (type.Equals("lower"))
            {
                FilteredList = ListAllClothes().Where(x => x.UnitPrice < price).ToList();
            }
            else if (type.Equals("higher"))
            {
                FilteredList = ListAllClothes().Where(x => x.UnitPrice > price).ToList();
            }
            else if (type.Equals("equal"))
            {
                FilteredList = ListAllClothes().Where(x => x.UnitPrice == price).ToList();
            }
            return FilteredList;
        }

        public Summary GetSummary(string name, string size, int quantity)
        {
            var currentClothes = clothesRepository.ClothesFromName(name, size);
            Summary summary = new Summary
            {
                ItemName = currentClothes.ItemName,
                Category = currentClothes.Category,
                Manufacturer = currentClothes.Manufacturer,
                Size = currentClothes.Size,
                Quantity = quantity,
                TotalPrice = currentClothes.UnitPrice * quantity
            };
            return summary;
        }
    }
}
