using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.Controllers
{
    [Route("api/[controller]")] // api/teapot
    [ApiController]
    public class TeapotController : ControllerBase
    {
        [HttpGet()] // GET api/teapot
        public ActionResult ServeTea()
        {
            return StatusCode(418, "I'm a little teapot; short and stout. Here is my handle, here is my spout."); // 418
        }
    }
}
