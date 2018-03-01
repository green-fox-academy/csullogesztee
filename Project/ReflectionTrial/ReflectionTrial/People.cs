using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTrial
{
    class People : ISchool
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public bool Clever { get; set; }
    }
}
