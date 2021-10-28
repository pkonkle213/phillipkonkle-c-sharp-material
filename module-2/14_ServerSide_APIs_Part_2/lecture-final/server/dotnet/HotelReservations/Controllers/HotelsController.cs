using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelDao hotelDao;
        private readonly IReservationDao reservationDao;

        public HotelsController(IHotelDao hotelDao, IReservationDao reservationDao)
        {
            this.hotelDao = hotelDao;
            this.reservationDao = reservationDao;
        }

        [HttpGet("hotels")]
        public ActionResult<List<Hotel>> ListHotels()
        {
            return Ok(hotelDao.List()); // 200 OK, Body: a list of Hotels
        }

        [HttpGet("yesterday/hotels")]
        public List<Hotel> ListHotelsOld()
        {
            return hotelDao.List(); // 200 OK, Body: a list of Hotels
        }

        [HttpGet("hotels/{id}")]
        public ActionResult GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            //string name = hotel.Name;

            // TODO: What if hotel is null? How do we return a 404?
            if (hotel == null)
            {
                return NotFound("The hotel you're looking for is not here"); // 404, Body: "The hotel..."
            }

            // TODO: What happens if we get an exception here?

            return Ok(hotel); // 200, Body: hotel
        }

        [HttpGet("hotels/filter")]
        public ActionResult FilterByStateAndCity(string state, string city)
        {
            List<Hotel> filteredHotels = new List<Hotel>();

            List<Hotel> hotels = hotelDao.List();
            // return hotels that match state
            foreach (Hotel hotel in hotels)
            {
                if (city != null)
                {
                    // if city was passed we don't care about the state filter
                    if (hotel.Address.City.ToLower().Equals(city.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
                else
                {
                    if (hotel.Address.State.ToLower().Equals(state.ToLower()))
                    {
                        filteredHotels.Add(hotel);
                    }
                }
            }

            return Ok(filteredHotels);
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public ActionResult ListReservationsByHotel(int hotelId)
        {
            // TODO: What if the ID is negative?
            if (hotelId <= 0)
            {
                return BadRequest("The hotel ID " + hotelId + " is not a valid hotel"); // 400
            }

            // TODO: What if they give us a hotel that doesn't exist?
            Hotel hotel = hotelDao.Get(hotelId);
            if (hotel == null)
            {
                return NotFound(); // 404
            }

            List<Reservation> reservations = reservationDao.FindByHotel(hotelId);

            return base.Ok(reservations);
        }
    }
}
