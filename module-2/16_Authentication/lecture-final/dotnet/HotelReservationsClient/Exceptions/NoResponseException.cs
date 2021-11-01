using System;

namespace HotelReservationsClient.Exceptions
{
    public class NoResponseException : HotelException
    {
        public NoResponseException() : base() { }
        public NoResponseException(string message) : base(message) { }
        public NoResponseException(string message, Exception innerException) : base(message, innerException) { }
    }
}
