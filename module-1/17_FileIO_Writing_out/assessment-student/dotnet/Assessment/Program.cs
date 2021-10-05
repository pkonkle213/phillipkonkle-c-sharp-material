using System;

namespace Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create an object and call methods on it (manual testing) from this class.
            // You DO NOT need to prompt the user to type in any values

            HotelReservation reservation = new HotelReservation("Phillip Konkle", 5);
            decimal totalCharge = reservation.ActualTotal(true, true);

            Console.WriteLine(reservation.ToString());
        }
    }
}
