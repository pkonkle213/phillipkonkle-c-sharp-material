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

        // We need a way to add a bug

        // We need a way to CLOSE a bug

        // BONUS: We need a way to update a bug
        // BONUS: We need a way to get a single bug by its ID
    }
}
