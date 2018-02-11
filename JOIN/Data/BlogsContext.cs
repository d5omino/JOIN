using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JOIN.Models
{
    public class BlogsContext : DbContext
    {
        public BlogsContext (DbContextOptions<BlogsContext> options)
            : base(options)
        {
        }

        public DbSet<JOIN.Models.Blogs> Blogs { get; set; }
    }
}
