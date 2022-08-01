using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApartmentRentManagementSystem.Migrations
{
    public partial class Alhamdu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "UtilityBills",
                newName: "BankCode");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "UtilityBills",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "UtilityBills");

            migrationBuilder.RenameColumn(
                name: "BankCode",
                table: "UtilityBills",
                newName: "Description");
        }
    }
}
