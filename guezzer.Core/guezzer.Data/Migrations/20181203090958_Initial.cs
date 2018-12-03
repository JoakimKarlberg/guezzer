using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace guezzer.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TimesPlayed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("d59535d4-eae0-4e08-84d6-429c723c78be"), "Music" },
                    { new Guid("b3d660bc-1e6f-4b59-9e28-0ff2f8f22396"), "Funny" },
                    { new Guid("5e7032de-fad3-491b-a42e-b5b4b00f88d0"), "Random" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "TimesPlayed" },
                values: new object[,]
                {
                    { new Guid("910b9553-a81a-4e12-b208-7c9d82cb9300"), "BestPlayer", 0 },
                    { new Guid("219e82d7-7ccc-44a8-b9d5-eb7b676f4458"), "WorstPlayer", 0 },
                    { new Guid("4966a363-1f15-479f-a971-77fe0a56fd70"), "OkayPlayer", 0 },
                    { new Guid("e562218a-5b41-4331-87e1-f79804b65c0b"), "Jonas", 0 },
                    { new Guid("781784e4-fd63-45b6-b1d8-0a624e4fab45"), "Jenny", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_CategoryId",
                table: "Results",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_PlayerId",
                table: "Results",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
