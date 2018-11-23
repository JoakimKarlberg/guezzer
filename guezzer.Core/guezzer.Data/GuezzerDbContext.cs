using guezzer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace guezzer.Data
{
    public class GuezzerDbContext : DbContext
    {
        public GuezzerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasMany(s => s.Scores)
                .WithOne(p => p.Player);
            modelBuilder.Entity<Category>()
                .HasMany(s => s.Scores)
                .WithOne(c => c.Category);

            base.OnModelCreating(modelBuilder);
        }
    }
}
