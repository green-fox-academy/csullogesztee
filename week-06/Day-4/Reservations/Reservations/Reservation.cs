using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Reservation : IReservationy
    {
        //Please note that the reservation code should contain 8 characters randomly from 0-Z, all uppercase letters.
        //Also, the DOW is randomly ordered to the bookings from an array.
        //DOW stands for Day of the Week (MON, TUE, etc.)
        //public string GetCodeBooking()
        Random random = new Random();

        string[] DOW = new string[7] { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };

        List<char> alphabet = Enumerable.Range(0, 26).Select(i => Convert.ToChar('A' + i)).ToList();
        List<char> numbers = Enumerable.Range(0, 10).Select(i => Convert.ToChar('0' + i)).ToList();

        public List<char> AlpabetWithNumbers()
        {
            List<char> newList = new List<char>();
            newList.AddRange(alphabet);
            newList.AddRange(numbers);

            return newList;
        }

        public string GetCodeBooking()
        {
            string BookingCode = "AAAAAAAA";
            char[] CodeArray = BookingCode.ToCharArray();

            for(int i = 0; i < 8; i++)
            {
                CodeArray[i] = AlpabetWithNumbers()[random.Next(0, 37)];
            }

            BookingCode = CodeArray.Aggregate(new StringBuilder(), (text, next) => text.Append(next)).ToString();

            return BookingCode;
        }

        public string GetDowBooking()
        {
            return DOW[random.Next(0, 8)];
        }
    }
}
 