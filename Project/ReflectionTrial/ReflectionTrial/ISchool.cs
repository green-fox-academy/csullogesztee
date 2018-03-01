using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTrial
{
    interface ISchool
    {
        string Name { get; set; }
        string Status { get; set; }
        int Age { get; set; }
        bool Clever { get; set; }
    }
}
