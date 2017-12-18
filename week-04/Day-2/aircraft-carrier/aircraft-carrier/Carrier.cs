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

        public Carrier()
        {
            SumHealthPoint = 5000;
            CurrentAmmo = AllAmmo;
        }

        public Carrier(int HP)
        {
            SumHealthPoint = HP;
        }

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
                aircraft.ReFill(AllAmmo);
                CurrentAmmo = CurrentAmmo - aircraft.ReFill(AllAmmo);
            }
        }

        public void GetFight(Carrier othercarrier)
        {
            int SumDamage = 0;
            foreach (Aircraft aircraft in othercarrier.aircraftsOfCarrier)
            {
                SumDamage = SumDamage + aircraft.Fight();
            }
            SumHealthPoint = SumHealthPoint - SumDamage;
        }

        public void GetStatusAirCrafts()
        {
            Console.WriteLine("Aircrafts:");
            foreach (Aircraft aircraft in aircraftsOfCarrier)
            {
                Console.WriteLine("Type " + aircraft.ToString() + ", Ammo: " + aircraft.MaxAmmo + ", Base Damage: " + aircraft.BaseDamage + ", All Damage: " + aircraft.BaseDamage * aircraft.CurrentAmmo);
            }
        }

        public void GetStatusCarrier()
        {
            if (SumHealthPoint > 0)
            {
                Console.WriteLine("HP: " + SumHealthPoint + ", Aircraft count: " + aircraftsOfCarrier.Count + ", Ammo Storage: " + CurrentAmmo + ", Total Damage: " );
            }
            else
            {
                Console.WriteLine("It's dead Jim :(");
            }
        }
    }
}
