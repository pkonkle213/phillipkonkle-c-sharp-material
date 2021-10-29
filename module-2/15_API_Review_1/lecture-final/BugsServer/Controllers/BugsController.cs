using BugsServer.DAO;
using BugsServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsServer.Controllers
{
    [Route("/")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly IBugDao bugs;

        public BugsController(IBugDao bugs)
        {
            this.bugs = bugs;
        }

        // We need a way to get all bugs
        [HttpGet("bugs")]
        public ActionResult GetAll()
        {
            return Ok(this.bugs.GetAllBugs());
        }

        // We need a way to add a bug
        [HttpPost("bugs")]
        public ActionResult AddBug(Bug bug)
        {
            Bug newBug = this.bugs.CreateBug(bug);

            return Created($"bugs/{newBug.Id}", newBug);
        }

        // We need a way to CLOSE a bug
        [HttpDelete("bugs/{id}")]
        public ActionResult CloseBug(int id)
        {
            this.bugs.CloseBug(id);

            Bug bug = this.bugs.FindById(id);
            if (bug == null)
            {
                return NotFound("No bug exists with that ID. Clippy probably killed it.");
            }

            return Ok(bug);
        }

        // BONUS: We need a way to update a bug
        // BONUS: We need a way to get a single bug by its ID
    }
}
