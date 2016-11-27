using CinemaBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaBooking.Data
{
    public class CinemaContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Screening> Screenings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Cinema.db");
        }
        
    }
}