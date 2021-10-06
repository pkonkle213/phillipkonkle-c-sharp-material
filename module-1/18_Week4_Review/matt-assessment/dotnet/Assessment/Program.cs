using Assessment.Discussions;
using System;

namespace Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create an object and call methods on it (manual testing) from this class.
            HotelReservation reservation = new HotelReservation("Matt", 2);
            Console.WriteLine(reservation.CalcuateTotal(true, true));
            Console.WriteLine(reservation); // Calls .ToString()



            // The code below is unrelated to the assessment but makes for some nice talking points


            // Uncomment for discussion 1
            // ParametersDiscussion discussion1 = new ParametersDiscussion();
            // discussion1.LaunchPad();            

            // Uncomment for discussion 2
            // ListDiscussion discussion2 = new ListDiscussion();
            // discussion2.Launchpad();
        }
    }
}
