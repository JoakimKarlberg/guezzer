﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using guezzer.Data;

namespace guezzer.Data.Migrations
{
    [DbContext(typeof(GuezzerDbContext))]
    partial class GuezzerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("guezzer.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = new Guid("b16552a4-c190-4408-9027-c7bf7999223b"), Type = "Music" },
                        new { Id = new Guid("121849ea-b75c-4a35-9242-cb784baeb5d3"), Type = "Funny" },
                        new { Id = new Guid("adf05187-a42c-405a-a084-d7db91a2ace6"), Type = "Random" }
                    );
                });

            modelBuilder.Entity("guezzer.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("TimesPlayed");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new { Id = new Guid("3f2d1ac4-89dc-402a-8c72-b390ff31482d"), Name = "BestPlayer", TimesPlayed = 0 },
                        new { Id = new Guid("485f0d57-9868-4be9-ad39-f70bab785fac"), Name = "WorstPlayer", TimesPlayed = 0 }
                    );
                });

            modelBuilder.Entity("guezzer.Entities.Result", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoryId");

                    b.Property<Guid?>("PlayerId");

                    b.Property<int>("Score");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("guezzer.Entities.Result", b =>
                {
                    b.HasOne("guezzer.Entities.Category", "Category")
                        .WithMany("Results")
                        .HasForeignKey("CategoryId");

                    b.HasOne("guezzer.Entities.Player", "Player")
                        .WithMany("Results")
                        .HasForeignKey("PlayerId");
                });
#pragma warning restore 612, 618
        }
    }
}
