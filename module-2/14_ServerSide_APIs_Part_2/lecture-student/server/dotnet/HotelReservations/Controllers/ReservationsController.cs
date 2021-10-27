using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationDao reservationDao;

        public ReservationsController(IReservationDao reservationDao)
        {
            this.reservationDao = reservationDao;
        }

        [HttpGet] // Reservations
        public ActionResult ListReservations()
        {
            return Ok(reservationDao.List());
        }

        [HttpGet("{id}")] // Reservations/42
        public ActionResult GetReservation(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            // TODO: What if reservation is null? How do we return a 404?

            return Ok(reservation);
        }

        [HttpPost] // Reservations
        public ActionResult AddReservation(Reservation reservation)
        {
            Reservation newReservation = reservationDao.Create(reservation);

            // TODO: How do we give back a 201 created instead?

            return Ok(newReservation);
        }

        // Let's add validation to our Reservation model

        // PUT reservations/{id}

        // DELETE reservations/{id}

        // Let's also add a TeapotController with a GET to get a 418 status code. For science!
    }
}
