using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private static IReservationDao reservationDao;

        public ReservationsController(IReservationDao _reservationDao)
        {
            reservationDao = _reservationDao;
        }

        [HttpGet("reservations")]
        public ActionResult<List<Reservation>> ListReservations()
        {
            return reservationDao.List();
        }

        [HttpGet("reservations/{id}")]
        public ActionResult<Reservation> GetReservation(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            // TODO: What if reservation is null? How do we return a 404?

            return reservation;
        }

        [HttpPost("reservations")]
        public ActionResult<Reservation> AddReservation(Reservation reservation)
        {
            Reservation newReservation = reservationDao.Create(reservation);

            // TODO: How do we give back a 201 created instead?

            return newReservation;
        }

        // PUT reservations/{id}

        // DELETE reservations/{id}
    }
}
