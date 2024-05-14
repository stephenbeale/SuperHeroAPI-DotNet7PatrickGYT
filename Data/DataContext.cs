using Microsoft.EntityFrameworkCore;

using SuperHeroAPI_DotNet7PatrickGYT.Controllers.Entities;

using System.Data.Common;

namespace SuperHeroAPI_DotNet7PatrickGYT.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
