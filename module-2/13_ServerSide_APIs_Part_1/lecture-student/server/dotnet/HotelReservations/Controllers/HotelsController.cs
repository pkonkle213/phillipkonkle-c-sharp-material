using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")] // If there is a specific route here, it gets prepended to any route for a method below
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelDao _hotelDao;
        private readonly IReservationDao _reservationDao;

        public HotelsController()
        {
            _hotelDao = new HotelDao();
            _reservationDao = new ReservationDao();
        }

        /// <summary>
        /// This method returns a simple greeting message to show you that ASP .NET works
        /// </summary>
        [HttpGet("greeting")] // Responds to GET requests to /Greeting
        public string HelloWorld()
        {
            return "Hello .NET Purple. Welcome to ASP .NET";
        }

        // GET hotels - Get all available hotels

        // GET hotels/{someHotelId} - Get a specific hotel

        // GET reservations - Get all reservations

        // GET reservations/{someReservationId} - Get a specific reservation

        // GET hotels/{someHotelId}/reservations - Get all reservations for a given hotel

        // GET hotels/filter - Get hotels, but filtered down by state or city based on the query string parameters
        // Query string parameters must be named "state" and "city" respectively

        // POST reservations - Add a new reservation
    }
}
