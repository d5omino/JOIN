using Microsoft.EntityFrameworkCore;

namespace JOIN.Data
{
    public class VideoDbContext : DbContext
    {

        public VideoDbContext(DbContextOptions<VideoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Videos> Videos { get; set; }


    }
}
