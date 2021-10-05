using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMaker
{
    public class Answers
    {
        public string Name { get; set; }
        public bool Correct
        {
            get
            {
                if (this.Name.Contains('*'))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
