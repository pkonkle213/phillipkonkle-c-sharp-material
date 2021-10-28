using System;
using System.Collections.Generic;
using System.Text;

namespace FactsClient
{
    public class NorrisApiFact
    {
        // TODO: This needs to have properties that match those on the server

        public int Id { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            return $"{Id}) {Text}";
        }
    }
}
