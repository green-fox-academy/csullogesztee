using IAmGroot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmGroot.Services
{
    public class CargoService
    {
        public Cargo cargo;
        public Result result;

        public CargoService(Cargo cargo, Result result)
        {
            this.cargo = cargo;
            this.result = result;
        }

        public void Fill(string type, int amount)
        {
            if (type == ".25")
            {
                cargo.Caliber25 += amount;
            }
            if (type == ".30")
            {
                cargo.Caliber30 += amount;
            }
            if (type == ".50")
            {
                cargo.Caliber50 += amount;
            }
            cargo.CargoCurrent += amount;
        }

        public void ShipStatus()
        {
            double percentage = cargo.CargoCurrent / cargo.CargoMax * 100;
            if (percentage == 0)
            {
                cargo.ShipStatus = "empty";
            }
            else
            {
                cargo.ShipStatus = percentage.ToString() + "%";
            }
            if (percentage == 100)
            {
                cargo.ShipStatus = "full";
            }
            if (percentage > 100)
            {
                cargo.ShipStatus = "overloaded";
            }
        }

        public void Ready()
        {
            cargo.Ready = cargo.CargoCurrent == cargo.CargoMax;
        }

        public void GetResult()
        {
            result.Caliber25 = cargo.Caliber25;
            result.Caliber30 = cargo.Caliber30;
            result.Caliber50 = cargo.Caliber50;
            result.ShipStatus = cargo.ShipStatus;
            result.Ready = cargo.Ready;
        }
    }
}
