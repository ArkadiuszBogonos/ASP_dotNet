using Microsoft.EntityFrameworkCore.Migrations;

namespace WypozyczalniaPojazdowElektrycznych3.Migrations
{
    public partial class VehicleColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Vehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Vehicles");
        }
    }
}
