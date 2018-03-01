using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using ReflectionTrial;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            SearchMethod<People> search = new SearchMethod<People>();

            SearchModel<string, People> search1 = new SearchModel<string, People>() { Class = "Teacher"};
            SearchModel<string, People> search2 = new SearchModel<string, People>() { Class = "Teacher", Property = "Name", Value = "Barna" };
            SearchModel<string, People> search3 = new SearchModel<string, People>() { Property = "Status", Value = "student" };
            SearchModel<int, People> search4 = new SearchModel<int, People>() { Property = "Age", Value = 12 };
            SearchModel<bool, People> search5 = new SearchModel<bool, People> { Property = "Clever", Value = true};

            string qsearch1 = "?Status=teacher";
            string qsearch2 = "?Status=student&&Name=Barna";
            string qsearch3 = "?Age=12";
            string qsearch4 = "?Age=12&&Status=student&&Clever=false";

            //Console.WriteLine("Original list:");
            //Printer(school.SchoolMembers);
            //Console.WriteLine("Filtered for class:");
            //Printer(search1.Filter(school.SchoolMembers));
            //Console.WriteLine("Filtered for class & property:");
            //Printer(search2.Filter(school.SchoolMembers));
            //Console.WriteLine("Filtered for just property:");
            //Printer(search3.Filter(school.SchoolMembers));
            //Console.WriteLine("Filtered for age property");
            //Printer(search4.Filter(school.SchoolMembers));
            //Console.WriteLine("Filtered for clever property");
            //Printer(search5.Filter(school.SchoolMembers));
            Console.WriteLine("query1");
            Printer(search.SearchFromQuery(qsearch1, school.SchoolMembers));
            Console.WriteLine("query2");
            Printer(search.SearchFromQuery(qsearch2, school.SchoolMembers));
            Console.WriteLine("query3");
            Printer(search.SearchFromQuery(qsearch3, school.SchoolMembers));
            Console.WriteLine("query4");
            Printer(search.SearchFromQuery(qsearch4, school.SchoolMembers));

            Console.ReadKey();
        }

        public static void Printer(List<People> list)
        {
            foreach (var member in list)
            {
                Console.WriteLine($"{member.Name} is a {member.Status}. He/She is {member.Age} years old and it's {member.Clever} he/she is clever.");
            }
        }
    }
}