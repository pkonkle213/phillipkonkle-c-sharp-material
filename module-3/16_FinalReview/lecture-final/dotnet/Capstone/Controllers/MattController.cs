using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("mattisms")] // mattisms
    [ApiController]
    public class MattController : ControllerBase
    {
        private readonly IMattismDAO mattisms;

        public MattController(IMattismDAO mattims)
        {
            this.mattisms = mattims;
        }

        [HttpGet] // GET /mattisms
        [AllowAnonymous]
        public ActionResult GetAllMattisms()
        {
            IEnumerable<Mattism> results = mattisms.GetAllMattisms();

            return Ok(results);
        }

        [HttpPost] // POST /mattisms
        [Authorize]
        public ActionResult AddNewMattism(Mattism newItem)
        {
            int userId = int.Parse(this.User.FindFirst("sub").Value);

            Mattism addedMattism = mattisms.AddMattism(userId, newItem);

            return Created("/mattisms/" + addedMattism.Id, addedMattism);
        }
    }
}
