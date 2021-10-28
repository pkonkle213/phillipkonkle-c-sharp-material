using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    public abstract class HotelReservationsControllerBase : ControllerBase
    {
        protected ActionResult ImATeapot()
        {
            return StatusCode(418, "Tea!!!");
        }
    }

    [Route("[controller]")]
    [ApiController]
    public class ReservationsController : HotelReservationsControllerBase
    {
        private readonly IReservationDao reservationDao;

        private const int MY_FAVORITE_NUMBER = 42;

        public ReservationsController(IReservationDao reservationDao) // Hey ASP.NET use Dependency Injection to give me this
        {
            this.reservationDao = reservationDao;
        }

        [HttpGet] // Reservations
        public ActionResult ListReservations()
        {
            return Ok(reservationDao.List());
        }

        [HttpGet("{id}")] // Reservations/42
        public ActionResult<Reservation> GetReservation(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Reservation ID must be positive"); // 400
            }

            Reservation reservation = reservationDao.Get(id);

            // TODO: What if reservation is null? How do we return a 404?
            if (reservation == null)
            {
                return NotFound(); // 404
            }

            return Ok(reservation); // 200
        }

        [HttpPost] // Reservations
        public ActionResult AddReservation(Reservation reservation)
        {
            Reservation newReservation = reservationDao.Create(reservation);

            // TODO: How do we give back a 201 created instead?
            string location = $"reservations/{newReservation.Id}"; // What we'd do a GET on to get details on the new reservation

            return Created(location, newReservation); // 201: location of the thing that exists, body to return
        }

        // Let's add validation to our Reservation model

        // PUT reservations/{id}
        [HttpPut("{id}")] // Reservations/42
        public ActionResult Update(Reservation updatedReservation, int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID"); // 400
            }
            if (updatedReservation.Id != id)
            {
                return BadRequest("The ID of the URL did not match the ID of the reservation"); // 400
            }

            Reservation existing = reservationDao.Get(id);
            if (existing == null)
            {
                return NotFound("No reservation found to update"); // 404
            }

            updatedReservation = reservationDao.Update(id, updatedReservation);

            return Ok(updatedReservation); // 200
        }

        // DELETE reservations/{id}
        [HttpDelete("{id}")]
        public ActionResult CancelReservation(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID"); // 400
            }

            bool isSuccessful = reservationDao.Delete(id);

            if (isSuccessful)
            {
                return NoContent(); // 204
            }
            else
            {
                return NotFound(); // 404
            }
        }

        // Let's also add a TeapotController with a GET to get a 418 status code. For science!
    }
}
