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

        public HotelsController(IHotelDao _hotelDao, IReservationDao _reservationDao)
        {
            hotelDao = _hotelDao;
            reservationDao = _reservationDao;
        }

        [HttpGet("hotels")]
        public ActionResult ListHotels()
        {
            return Ok(hotelDao.List());
        }

        [HttpGet("hotels/{id}")]
        public ActionResult GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            // TODO: What if hotel is null? How do we return a 404?

            // TODO: What happens if we get an exception here?

            return Ok(hotel);
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

            // TODO: What if they give us a hotel that doesn't exist?

            return Ok(reservationDao.FindByHotel(hotelId));
        }
    }
}
