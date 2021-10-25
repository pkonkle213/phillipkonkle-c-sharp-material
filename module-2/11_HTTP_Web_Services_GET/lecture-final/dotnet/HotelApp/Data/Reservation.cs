using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP_Web_Services_GET_lecture
{
    public class Reservation
    {
        public int Id { get; set; }
        public int HotelID { get; set; }
        public string FullName { get; set; }
        public string CheckinDate { get; set; }
        public string CheckoutDate { get; set; }
        public int Guests { get; set; }
    }
}
