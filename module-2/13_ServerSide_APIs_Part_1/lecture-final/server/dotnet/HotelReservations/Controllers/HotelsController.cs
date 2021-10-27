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
        private readonly IHotelDao hotelDao;
        private readonly IReservationDao reservationDao;

        public HotelsController()
        {
            this.hotelDao = new HotelDao();
            this.reservationDao = new ReservationDao();
        }

        /// <summary>
        /// This method returns a simple greeting message to show you that ASP .NET works
        /// </summary>
        [HttpGet("greeting")] // Responds to GET requests to /greeting
        public string HelloWorld()
        {
            return "Hello .NET 15! Welcome to ASP .NET";
        }

        // GET hotels - Get all available hotels
        /// <summary>
        /// Gets all the registered hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet("hotels")] // GET to /hotels
        public List<Hotel> GetAllAvailableHotels()
        {
            List<Hotel> results = hotelDao.List();

            return results;
        }

        /*
        [HttpGet("hotels")]
        public List<Hotel> GetHotelsWithRoaches()
        {
            return new List<Hotel>();
        }
        */

        // GET hotels/{someHotelId} - Get a specific hotel
        [HttpGet("hotels/{someHotelId}")]
        public Hotel GetHotelDetails(int someHotelId)
        {
            Hotel hotel = hotelDao.Get(someHotelId);

            return hotel;
        }

        // GET reservations - Get all reservations
        [HttpGet("reservations")]
        public List<Reservation> GimmieAllDaReservations() // Don't actually name methods like this in the real world
        {
            return reservationDao.List();
        }

        // GET reservations/{someReservationId} - Get a specific reservation
        [HttpGet("reservations/{id}")]
        public Reservation GetReservation(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            return reservation;
        }

        // GET hotels/{someHotelId}/reservations - Get all reservations for a given hotel
        [HttpGet("hotels/{id}/reservations")]
        public List<Reservation> FindReservationsForHotel(int id) // this is a route parameter and IS REQUIRED
        {
            List<Reservation> reservations = reservationDao.FindByHotel(id);

            return reservations;
        }

        // GET hotels/filter - Get hotels, but filtered down by state or city based on the query string parameters
        // Query string parameters must be named "state" and "city" respectively
        [HttpGet("hotels/filter")]
        // Why can't we do: HttpGet("hotels/filter?state={someState}&city={someCity}") - Because ASP .NET Team's decisions
        public List<Hotel> SearchHotels(string state, string city) // These are query string parameters which are OPTIONAL
        {
            List<Hotel> hotels = hotelDao.List();
            List<Hotel> results = new List<Hotel>();

            foreach (Hotel hotel in hotels)
            {
                // If we're not filtering at all, add the hotel
                if (state == null && city == null)
                {
                    results.Add(hotel);
                }
                // If they're filtering by city, include hotels with that city
                else if (city != null)
                {
                    if (hotel.Address.City.ToUpper() == city.ToUpper())
                    {
                        results.Add(hotel);
                    }
                }
                // If they're filtering by state, include hotels with that state
                else 
                {
                    if (hotel.Address.State.ToUpper() == state.ToUpper())
                    {
                        results.Add(hotel);
                    }
                }
            }

            return results;
        }

        // POST reservations - Add a new reservation
        [HttpPost("reservations")]
        public Reservation CreateABrandSpankingNewReservation(Reservation reservation)
        {
            Reservation createdReservation = reservationDao.Create(reservation);

            return createdReservation;
        }
    }
}
