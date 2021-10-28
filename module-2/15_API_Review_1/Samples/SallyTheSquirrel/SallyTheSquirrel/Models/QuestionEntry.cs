using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechElevator.SallyTheSquirrel.Server.Models
{
    public class QuestionEntry
    {
        [Required]
        public string Question { get; set; }

        public string Answer { get; set; }

        [Url]
        public string LearnMoreUrl { get; set; }

        [Range(1, 3)]
        public int Difficulty { get; set; } = 1;

        public string[] Tags { get; set; }

        public int Id { get; set; }
    }
}
