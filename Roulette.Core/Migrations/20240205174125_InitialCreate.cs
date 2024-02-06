using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Roulette.Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PickDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PickDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pick",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    PickDetailsId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pick", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pick_PickDetails_PickDetailsId",
                        column: x => x.PickDetailsId,
                        principalTable: "PickDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    Multiplier = table.Column<decimal>(type: "TEXT", nullable: false),
                    BetType = table.Column<int>(type: "INTEGER", nullable: false),
                    PickId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bets_Pick_PickId",
                        column: x => x.PickId,
                        principalTable: "Pick",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bets_PickId",
                table: "Bets",
                column: "PickId");

            migrationBuilder.CreateIndex(
                name: "IX_Pick_PickDetailsId",
                table: "Pick",
                column: "PickDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Pick");

            migrationBuilder.DropTable(
                name: "PickDetails");
        }
    }
}
