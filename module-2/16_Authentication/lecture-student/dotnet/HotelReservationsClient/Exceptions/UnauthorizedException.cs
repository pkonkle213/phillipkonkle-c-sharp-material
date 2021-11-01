﻿using System;

namespace HotelReservationsClient.Exceptions
{
    public class UnauthorizedException : HotelException
    {
        public UnauthorizedException() : base() { }
        public UnauthorizedException(string message) : base(message) { }
        public UnauthorizedException(string message, Exception innerException) : base(message, innerException) { }
    }
}
