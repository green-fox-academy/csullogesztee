using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTrial
{
    class SearchModel<T, U> where U : class
    {
        public string Class { get; set; }
        public string Property { get; set; }
        public T Value { get; set; }

        public List<U> Filter(List<U> list)
        {
            var filteredList = new List<U>();
            if (Class != null)
            {
                filteredList = list.Where(x => x.GetType().Name.Equals(Class)).ToList();
            }
            if (Property != null)
            {
                filteredList = filteredList.Where(x => x.GetType().GetProperty($"{Property}").GetValue(x).Equals(Value)).ToList();
            }
            if (Class == null && Property != null)
            {
                filteredList = list.Where(x => x.GetType().GetProperty($"{Property}").GetValue(x).Equals(Value)).ToList();
            }
            return filteredList;
        }
    }
}
