using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        // create a constructor 
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options) 
        {

        }
        // telling entity framework to create Regions table in db if not exist
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
