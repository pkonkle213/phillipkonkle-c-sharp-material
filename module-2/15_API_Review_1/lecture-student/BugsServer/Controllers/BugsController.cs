using BugsServer.Models;
using BugsServer.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugsServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly IBugDao bugs;

        public BugsController(IBugDao bugs)
        {
            this.bugs = bugs;
        }

        // We need a way to get all bugs
        [HttpGet()]
        public ActionResult GetBugs()
        {
            return Ok(bugs.GetAllBugs());
        }

        // We need a way to add a bug
        [HttpPost()]
        public ActionResult AddBug(Bug bug)
        {
            Bug newBug = bugs.CreateBug(bug);
            string location = $"api/Bugs/{newBug.Id}";
            return Created(location, newBug);
        }

        // We need a way to CLOSE a bug
        [HttpPut("{id}")]
        public ActionResult CloseBug(Bug bug, int id)
        {
            bugs.CloseBug(id);
            return Ok(bug);
        }

        // BONUS: We need a way to update a bug
        [HttpPut("update/{id}")]
        public ActionResult UpdateBug(Bug bug, int id)
        {
            bugs.UpdateBug(bug);
            bug = bugs.FindById(id);
            return Ok(bug);
        }
        // BONUS: We need a way to get a single bug by its ID
        [HttpGet("{id}")]
        public ActionResult GetBug(int id)
        {
            return Ok(bugs.FindById(id));
        }
    }
}
