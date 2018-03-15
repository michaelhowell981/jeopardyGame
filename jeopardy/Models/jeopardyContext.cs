using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using jeopardy.Models;

namespace jeopardy.Models
{
    public class jeopardyContext: DbContext
    {
        public jeopardyContext(DbContextOptions<jeopardyContext> options)
            : base(options)
        {

        }

        public DbSet<question> CategoryName { get; set; }
        public DbSet<question> Id { get; set; }
        public DbSet<question> answerText { get; set; }
        public DbSet<question> questionValue { get; set; }
    }
}
