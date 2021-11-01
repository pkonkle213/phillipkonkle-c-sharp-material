using System;

namespace HotelReservationsClient.Exceptions
{
    public class ForbiddenException : HotelException
    {
        public ForbiddenException() : base() { }
        public ForbiddenException(string message) : base(message) { }
        public ForbiddenException(string message, Exception innerException) : base(message, innerException) { }
    }
}
