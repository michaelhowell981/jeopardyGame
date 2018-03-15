using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jeopardy.Models
{
    public class question
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
        public string answerText { get; set; }
        public string questionValue { get; set; }
    }
}
