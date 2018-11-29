﻿using guezzer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace guezzer.Api
{
    public class GuezzerDbContextFactory : IDesignTimeDbContextFactory<GuezzerDbContext>
    {
        public GuezzerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GuezzerDbContext>();
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=GuezzerDb;Trusted_Connection=True;MultipleActiveResultSets=true",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(GuezzerDbContext).GetTypeInfo().Assembly.GetName().Name));

            return new GuezzerDbContext(builder.Options);
        }
    }
}
