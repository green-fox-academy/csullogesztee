using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            //Booking# 1WBA3OMU for THU
            //Booking# 0V5OH7VS for WED
            //Booking# CV6QOAJO for MON
            //Booking# 03GHEJMV for SAT
            //Booking# M5JFB32I for THU
            //Booking# W30PF0E0 for SAT
            //Booking# S0R70GMN for SAT
            //Booking# 3E032B3C for WED
            //Booking# OD27E36J for SAT
            //Booking# 4MEU0657 for MON
            Reservation reservation = new Reservation();
            Console.WriteLine(reservation.AlpabetWithNumbers().Count() + " " + reservation.GetCodeBooking() + " " + reservation.GetDowBooking());
            Console.ReadKey();
        }
    }
}
