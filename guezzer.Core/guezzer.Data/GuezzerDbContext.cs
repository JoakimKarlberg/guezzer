﻿using guezzer.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace guezzer.Data
{
    public class GuezzerDbContext : DbContext, IDisposable
    {
        public GuezzerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}
