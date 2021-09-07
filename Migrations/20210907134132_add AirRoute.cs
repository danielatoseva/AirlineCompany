using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirlineCompany.Migrations
{
    public partial class addAirRoute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirRoutesID",
                table: "FlightDestinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AirRoutes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Distance = table.Column<uint>(type: "int unsigned", nullable: false),
                    Altitude = table.Column<uint>(type: "int unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirRoutes", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FlightDestinations_AirRoutesID",
                table: "FlightDestinations",
                column: "AirRoutesID");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightDestinations_AirRoutes_AirRoutesID",
                table: "FlightDestinations",
                column: "AirRoutesID",
                principalTable: "AirRoutes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightDestinations_AirRoutes_AirRoutesID",
                table: "FlightDestinations");

            migrationBuilder.DropTable(
                name: "AirRoutes");

            migrationBuilder.DropIndex(
                name: "IX_FlightDestinations_AirRoutesID",
                table: "FlightDestinations");

            migrationBuilder.DropColumn(
                name: "AirRoutesID",
                table: "FlightDestinations");
        }
    }
}
