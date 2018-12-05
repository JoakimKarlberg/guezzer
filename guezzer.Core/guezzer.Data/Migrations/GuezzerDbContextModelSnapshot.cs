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
                        new { Id = new Guid("d59535d4-eae0-4e08-84d6-429c723c78be"), Type = "Music" },
                        new { Id = new Guid("b3d660bc-1e6f-4b59-9e28-0ff2f8f22396"), Type = "Funny" },
                        new { Id = new Guid("5e7032de-fad3-491b-a42e-b5b4b00f88d0"), Type = "Random" }
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
                        new { Id = new Guid("910b9553-a81a-4e12-b208-7c9d82cb9300"), Name = "BestPlayer", TimesPlayed = 0 },
                        new { Id = new Guid("219e82d7-7ccc-44a8-b9d5-eb7b676f4458"), Name = "WorstPlayer", TimesPlayed = 0 },
                        new { Id = new Guid("4966a363-1f15-479f-a971-77fe0a56fd70"), Name = "OkayPlayer", TimesPlayed = 0 },
                        new { Id = new Guid("e562218a-5b41-4331-87e1-f79804b65c0b"), Name = "Jonas", TimesPlayed = 0 },
                        new { Id = new Guid("781784e4-fd63-45b6-b1d8-0a624e4fab45"), Name = "Jenny", TimesPlayed = 0 }
                    );
                });

            modelBuilder.Entity("guezzer.Entities.Result", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<Guid>("PlayerId");

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
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("guezzer.Entities.Player", "Player")
                        .WithMany("Results")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
