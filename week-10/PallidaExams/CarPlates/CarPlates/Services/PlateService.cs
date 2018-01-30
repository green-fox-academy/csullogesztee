using CarPlates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPlates.Repositories
{
    public class PlateService
    {
        private PlateRepository plateRepository;

        public PlateService(PlateRepository plateRepository)
        {
            this.plateRepository = plateRepository;
        }

        public List<LicencePlate> SearchedCar(SearchItem search)
        {
            List<LicencePlate> FilteredList = plateRepository.AllCar();

            if (search.Q != null)
            {
                FilteredList = plateRepository.AllCar().Where(x => x.Plate.Contains(search.Q)).ToList();
            }

            if(search.Police == 1)
            {
                FilteredList = plateRepository.AllCar().Where(x => x.Plate.StartsWith("RB")).ToList();
            }

            if (search.Diplomat == 1)
            {
                FilteredList = plateRepository.AllCar().Where(x => x.Plate.StartsWith("DT")).ToList();
            }

            return FilteredList;
        }

        internal List<LicencePlate> SearchBrand(string brand)
        {
            return plateRepository.AllCar().Where(x => x.CarBrand.Equals(brand)).ToList();
        }
    }
}
