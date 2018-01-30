using CarPlates.Entities;
using CarPlates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlates.Repositories
{
    public class PlateRepository
    {
        private PlateContext plateContext;

        public PlateRepository(PlateContext plateContext)
        {
            this.plateContext = plateContext;
        }

        public List<LicencePlate> AllCar()
        {
            return plateContext.LicencePlates.ToList();
        }
    }
}
