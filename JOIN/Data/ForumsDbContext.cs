using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JOIN.Models
{
    public class ForumsDbContext : DbContext
    {
        public ForumsDbContext (DbContextOptions<ForumsDbContext> options)
            : base(options)
        {
        }

        public DbSet<JOIN.Models.Forums> Forums { get; set; }
    }
}
