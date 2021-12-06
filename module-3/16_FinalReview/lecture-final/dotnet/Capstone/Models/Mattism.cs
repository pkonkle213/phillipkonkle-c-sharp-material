using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Mattism
    {
        public int Id { get; set; } = 0;

        [Required]
        [MaxLength(150)]
        public string Text { get; set; }

        [Required]
        [MaxLength(15)]
        public string Frequency { get; set; }

        public bool IsFavorite { get; set; } = false;
    }
}
