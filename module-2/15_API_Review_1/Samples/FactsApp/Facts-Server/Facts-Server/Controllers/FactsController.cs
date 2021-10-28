using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facts_Server.Controllers
{
    [Route("facts")]
    [ApiController]
    public class FactsController : ControllerBase
    {
        private static FactsDao facts;

        public FactsController()
        {
            if (facts == null)
            {
                facts = new FactsDao();
            }
        }

        // 1. Add a new GET method to handle gets to /facts
        // This should return the results of the DAO's GetAllFacts method
        [HttpGet()]
        public List<ChuckNorrisFact> GetFactsList()
        {
            return facts.GetAllFacts();
        }

        [HttpGet("{id}")]
        public ActionResult<ChuckNorrisFact> GetFact(int id)
        {
            ChuckNorrisFact fact = facts.GetFactById(id);

            if (fact == null)
            {
                return NotFound();
            }

            return fact;
        }

        [HttpPut()]
        public ActionResult<ChuckNorrisFact> UpdateFact(ChuckNorrisFact fact)
        {
            bool updated = facts.UpdateFact(fact);

            if (!updated)
            {
                return NotFound();
            }

            return fact;
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteFact(int id)
        {
            if (!facts.DeleteFact(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // 2. Add a method to allow folks to POST a new fact.
        // This should call the DAO's AddFact method with the new fact
        [HttpPost()]
        public ActionResult<ChuckNorrisFact> AddNewFact(ChuckNorrisFact newFact)
        {
            ChuckNorrisFact createdFact = facts.AddFact(newFact);

            return Created($"/facts/{createdFact.Id}", newFact);
        }

    }
}
