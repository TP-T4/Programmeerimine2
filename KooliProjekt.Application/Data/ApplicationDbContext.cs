using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KooliProjekt.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<TastingLog> TastingLogs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
