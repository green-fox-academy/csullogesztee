using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class Carrier
    {
        public int SumHealthPoint { get; set; } = 0;
        public List<Aircraft> aircraftsOfCarrier = new List<Aircraft>();
        public int AllAmmo = 2300;
        public int CurrentAmmo;
        public int TotalDamage = 0;

        public Carrier()
        {
            SumHealthPoint = 5000;
            CurrentAmmo = AllAmmo;        }

        public void AddAirCraft(string Type)
        {
            if (Type == "F16")
            {
                aircraftsOfCarrier.Add(new F16());
            }
            if (Type == "F35")
            {
                aircraftsOfCarrier.Add(new F35());
            }
        }

        public void Fill()
        {
            foreach (Aircraft aircraft in aircraftsOfCarrier)
            {
                if (CurrentAmmo > aircraft.MaxAmmo)
                {
                    CurrentAmmo = aircraft.ReFill(CurrentAmmo);
                }
                else
                {
                    if (aircraft.ToString() == "F35")
                    {
                        CurrentAmmo = aircraft.ReFill(CurrentAmmo);
                    }
                }
            }
        }

        public void GetFight(Carrier othercarrier)
        {
            foreach (Aircraft aircraft in othercarrier.aircraftsOfCarrier)
            {
                TotalDamage = TotalDamage + aircraft.Fight();
            }
            SumHealthPoint = SumHealthPoint - TotalDamage;
        }

        public List<string> GetStatusAirCrafts()
        {
            List<string> statusesOfAircrafts = new List<string>();

            foreach (Aircraft aircraft in aircraftsOfCarrier)
            {
                 statusesOfAircrafts.Add(string.Format("Type {0}, Ammo: {1}, Base Damage: {2}, All Damage: {3}",
                    aircraft.ToString(), aircraft.CurrentAmmo, aircraft.BaseDamage, (aircraft.BaseDamage * aircraft.CurrentAmmo)));
            }
            return statusesOfAircrafts;
        }

        public string GetStatusCarrier()
        {
            if (SumHealthPoint > 0)
            {
                return string.Format("HP: {0}, Aircraft count: {1}, Ammo Storage: {2}, Total Damage: {3}",
                    SumHealthPoint, aircraftsOfCarrier.Count, CurrentAmmo, TotalDamage );
            }
            else
            {
                return string.Format("It's dead Jim :(");
            }
        }
    }
}
