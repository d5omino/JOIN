
using JOIN.Models;

using Microsoft.EntityFrameworkCore;

namespace JOIN.Data
{
    public class JoinDbContext:DbContext
    {
        public JoinDbContext(DbContextOptions<JoinDbContext> options) : base(options)
        {

        }

        public DbSet<Registration> Registrations { get; set; }
    }
}
