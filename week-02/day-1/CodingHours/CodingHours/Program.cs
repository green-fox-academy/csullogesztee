using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            double codinghours = 6;
            // The semester is 17 weeks long
            double weeks = 17;
            double codingdays = 5;
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            double semestercodinghours = codinghours * weeks * codingdays;
            Console.WriteLine(semestercodinghours);
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            double weeklyworkinghours = 52;
            double semesterworkinghours = weeks * weeklyworkinghours;
            Console.WriteLine(semestercodinghours / semesterworkinghours * 100 + "%");
         

        }
    }
}