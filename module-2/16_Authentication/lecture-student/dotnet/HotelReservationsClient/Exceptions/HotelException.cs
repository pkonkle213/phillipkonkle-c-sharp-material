using System;

namespace HotelReservationsClient.Exceptions
{
    public abstract class HotelException : ApplicationException
    {
        protected HotelException()
        {
        }

        protected HotelException(string message) : base(message)
        {
        }

        protected HotelException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
