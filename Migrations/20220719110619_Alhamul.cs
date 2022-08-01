using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentRentManagementSystem.Migrations
{
    public partial class Alhamul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ApartmentTotalPrice",
                table: "Apartments",
                type: "decimal(65,30)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentTotalPrice",
                table: "Apartments");
        }
    }
}
