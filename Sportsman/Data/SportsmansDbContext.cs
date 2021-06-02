using Sportsman.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Sportsman.Data
{
    public class SportsmansDbContext : DbContext
    {
        public SportsmansDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Sportsman> Sportsmans { get; set; }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Sport> Sports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Sportsman>()
                .HasOne<Team>(j => j.Team)
                .WithMany(s => s.Sportsmans);
        }
    }
}
