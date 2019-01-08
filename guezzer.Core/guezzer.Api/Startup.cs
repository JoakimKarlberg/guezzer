using guezzer.Api.Repositories;
using guezzer.Data;
using guezzer.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace guezzer.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddDbContext<GuezzerDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddControllersAsServices()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                });

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IResultRepository, ResultRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            Initialize(app);
            app.UseHttpsRedirection();
            app.UseMvc();
        }

        // This method initializes the DB and populates it with data if the tables are empty
        public async void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var _context = serviceScope.ServiceProvider.GetRequiredService<GuezzerDbContext>();

                _context.Database.EnsureCreated();

                var categories = new List<Category>();
                var players = new List<Player>();
                var results = new List<Result>();

                if (!_context.Categories.Any())
                {
                    categories.Add(new Category
                    {
                        Id = Guid.NewGuid(),
                        Type = "Music"
                    });
                    categories.Add(new Category
                    {
                        Id = Guid.NewGuid(),
                        Type = "Funny"
                    });
                    categories.Add(new Category
                    {
                        Id = Guid.NewGuid(),
                        Type = "Random"
                    });
                }

                if (!_context.Players.Any())
                {
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "Joakim"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "Simone"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "Molyn"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "Camilla"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "Johanna"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "Pontus"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "Gandalf"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "AAA"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "BBB"
                    });
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        Name = "CCC"
                    });
                }

                if (!_context.Results.Any())
                {
                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[0],
                        Player = players[0],
                        Score = 5,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[0],
                        Player = players[1],
                        Score = 15,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[0],
                        Player = players[2],
                        Score = 10,
                        Updated = DateTime.Now
                    });
                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[1],
                        Player = players[3],
                        Score = 34,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[1],
                        Player = players[4],
                        Score = 26,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[1],
                        Player = players[5],
                        Score = 1,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[2],
                        Player = players[6],
                        Score = 18,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[2],
                        Player = players[7],
                        Score = 54,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[2],
                        Player = players[8],
                        Score = 22,
                        Updated = DateTime.Now
                    });

                    results.Add(new Result
                    {
                        Id = Guid.NewGuid(),
                        Category = categories[2],
                        Player = players[9],
                        Score = 3,
                        Updated = DateTime.Now
                    });
                }

                foreach (var item in categories)
                {
                    await _context.Categories.AddAsync(item);
                }

                foreach (var item in players)
                {
                    await _context.Players.AddAsync(item);
                }

                foreach (var item in results)
                {
                    await _context.Results.AddAsync(item);
                }

                await _context.SaveChangesAsync();

            }
        }
    }
}
