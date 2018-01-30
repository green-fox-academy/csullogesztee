using ClothesMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesMarket.ViewModels
{
    public class ClothesViewModel
    {
        public List<string> Sizes { get; set; }
        public List<string> ItemNames { get; set; }
        public List<Clothes> Clothes { get; set; }
    }
}
