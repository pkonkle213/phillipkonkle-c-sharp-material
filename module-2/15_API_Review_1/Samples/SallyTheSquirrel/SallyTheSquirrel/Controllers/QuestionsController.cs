using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechElevator.SallyTheSquirrel.Server.Models;
using TechElevator.SallyTheSquirrel.Server.Repositories;

namespace TechElevator.SallyTheSquirrel.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionRepository _repository;

        public QuestionsController(IQuestionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<QuestionEntry>> Get()
        {
            return Ok(_repository.Questions);
        }

        [HttpGet("{id}")]
        public ActionResult<QuestionEntry> GetById(int id)
        {
            var question = _repository.FindQuestion(id);
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<QuestionEntry>> Update(int id, QuestionEntry newEntry)
        {
            var question = _repository.FindQuestion(id);
            if (question == null)
            {
                return NotFound();
            }

            if (id != newEntry.Id)
            {
                return BadRequest("New Question ID did not match the supplied URL");
            }

            _repository.UpdateQuestion(newEntry);

            return Ok(newEntry);
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<QuestionEntry>> Delete(int id)
        {
            if (_repository.DeleteQuestion(id))
            {
                return NoContent();
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<QuestionEntry> Add(QuestionEntry entry)
        {
            _repository.AddQuestion(entry);

            return Created($"/questions/{entry.Id}", entry);
        }
    }
}
