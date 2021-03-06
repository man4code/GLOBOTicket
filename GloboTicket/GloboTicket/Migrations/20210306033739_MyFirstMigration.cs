using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GloboTicket.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganiserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParticipantCount = table.Column<int>(type: "int", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "EventDate", "IsActive", "Name", "OrganiserName", "ParticipantCount", "Price", "Venue" },
                values: new object[] { 1, new DateTime(2021, 3, 11, 9, 7, 38, 22, DateTimeKind.Local).AddTicks(5101), true, "First Event 1", "Test Orrganizer 1", 60, 2000m, "Bangalore 560071" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
