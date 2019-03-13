using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineQuiz.Models
{
    public class OnlineQuizContext : DbContext
    {
        public OnlineQuizContext (DbContextOptions<OnlineQuizContext> options)
            : base(options)
        {
        }

        public DbSet<Quiz> Quiz { get; set; }
    }
}
