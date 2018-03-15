using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeopardy.Models;

namespace jeopardy.Data
{
    public class DbInitializer
    {
        public static void Initialize(jeopardyContext context)
        {
            context.Database.EnsureCreated();

            //Look for question Data.
            if (context.Id.Any())
            {
                return;
            }

            //Sample  Data for testing
            List<question> questions = new List<question>();
            question swords500 = new question()
            {
                Id = 1,
                categoryName = "swords500",
                answerText = "Popeye is this type of man.",
                questionValue = "500"
            };
            question swords200 = new question()
            {
                Id = 2,
                categoryName = "swords200",
                answerText = "The other term for a sword. Please state it in a Sean Connery accent.",
                questionValue = "200"

            };
            questions.Add(swords200);
            questions.Add(swords500);
        }
    }
}
