using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTrial
{
    class SearchMethod<T> where T : class
    {
        //string url = Request.QueryString.ToString();
        public List<T> SearchFromQuery(string query, List<T> list)
        {
            string pairsString = query.Remove(0, 1);
            var options = pairsString.Split(new[] { "&&" }, StringSplitOptions.None).ToList()
                .ToDictionary(x => x.Split('=')[0], x => x.Split('=')[1]);

            var filteredList = new List<T>();

            foreach (var option in options)
            {
                List<T> addedList = list.Where(x => x.GetType().GetProperty($"{option.Key}")
                 .GetValue(x).Equals(Convert.ChangeType(option.Value, Type.GetType(x.GetType()
                 .GetProperty($"{option.Key}").PropertyType.ToString())))).ToList();

                foreach (var element in addedList)
                {
                    if (!filteredList.Contains(element))
                    {
                        filteredList.Add(element);
                    }
                }
            }

            return filteredList;
        }
    }
}
