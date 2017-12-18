using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aircraft_carrier
{
    class Aircraft
    {
        public int MaxAmmo { get; set; }
        public int BaseDamage { get; set; }
        public int CurrentAmmo { get; set; }

        public int HealthPoint { get; set; }

        public Aircraft(int maxAmmo, int baseDamage)
        {
            MaxAmmo = maxAmmo;
            BaseDamage = baseDamage;
            CurrentAmmo = 0;
        }

        public int Fight()
        {
            int Damage = CurrentAmmo * BaseDamage;
            CurrentAmmo = 0;
            return Damage;
        }

        public int ReFill(int AmountOfFill)
        {
            if (AmountOfFill < MaxAmmo)
            {
                CurrentAmmo = AmountOfFill;
                return 0;
            }
            else
            {
                CurrentAmmo = MaxAmmo;
                return AmountOfFill - MaxAmmo;
            }
        }
    }
}
