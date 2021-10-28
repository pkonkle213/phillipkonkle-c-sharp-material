using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Facts_Server
{
    public class ChuckNorrisFact
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public ChuckNorrisFact() // Needed for serialization
        {

        }

        public ChuckNorrisFact(int id, string text)
        {
            this.Id = id;
            this.Text = text;
        }
    }
}
