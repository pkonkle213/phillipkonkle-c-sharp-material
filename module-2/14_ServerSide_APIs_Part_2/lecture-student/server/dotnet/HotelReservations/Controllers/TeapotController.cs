using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class TeapotController : ControllerBase
    {
        public TeapotController() // Empty constructor here for comparison purposes only
        {

        }

        [HttpGet("teapot")] // This is silly. Don't do this.
        public ActionResult<string> Teapot()
        {
            // TODO: What if I wanted to return a 418 I'm a teapot status code?

            return "I'm a little teapot; short and stout...";
        }

    }
}
