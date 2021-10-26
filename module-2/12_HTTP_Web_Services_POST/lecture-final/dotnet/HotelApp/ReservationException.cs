using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    public class ReservationException : Exception
    {
        public Reservation Reservation { get; }

        public ReservationException(Reservation reservation, string message) : base(message)
        {
            this.Reservation = reservation;
        }
    }
}
