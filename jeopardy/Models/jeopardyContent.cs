using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace jeopardy.Models
{
    public class jeopardyContent: DbContext
    {
        public jeopardyContent(DbContextOptions<jeopardyContent> options)
            : base(options)
            {

            }
            public DbSet<question> questions { get; set; }

        
    }
}
