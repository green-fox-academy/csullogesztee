using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmGroot.Models
{
    public class Cargo
    {
        public int Caliber25 { get; set; }
        public int Caliber30 { get; set; }
        public int Caliber50 { get; set; }
        public double CargoCurrent { get; set; }
        public double CargoMax { get; set; } = 12500;
        public string ShipStatus { get; set; }
        public bool Ready { get; set; }

    }
}
