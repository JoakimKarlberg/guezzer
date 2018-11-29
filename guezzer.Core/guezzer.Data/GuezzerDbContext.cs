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
        public DbSet<Result> Results { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasMany(r => r.Results)
                .WithOne(p => p.Player);
            modelBuilder.Entity<Category>()
                .HasMany(r => r.Results)
                .WithOne(c => c.Category);

            base.OnModelCreating(modelBuilder);
        }
    }
}
