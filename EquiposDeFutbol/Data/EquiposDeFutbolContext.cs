
using Microsoft.EntityFrameworkCore;
using EquiposDeFutbol.Models;


namespace EquiposDeFutbol.Data 
{
    public class EquiposDeFutbolContext : DbContext
    {
        public EquiposDeFutbolContext(DbContextOptions<EquiposDeFutbolContext> options) : base(options) 
        {
        }

        public DbSet<Competitions> Competitions {get; set;}
        public DbSet<Fixtures> Fixtures {get; set;}
        public DbSet<PlayerFixtures> PlayerFixtures {get; set;}
        public DbSet<PlayerPositions> PlayerPositions {get; set;}
        public DbSet<Players> Players {get; set;}
        public DbSet<Teams> Teams {get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerFixtures>().HasKey(c => new {c.FixtureID, c.PlayerID});
        }
       
    } 
}