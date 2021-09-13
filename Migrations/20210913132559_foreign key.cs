using Microsoft.EntityFrameworkCore.Migrations;

namespace AirlineCompany.Migrations
{
    public partial class foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Country_CountryID",
                table: "Destination");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightDestinations_AirRoutes_AirRoutesID",
                table: "FlightDestinations");

            migrationBuilder.RenameColumn(
                name: "AirRoutesID",
                table: "FlightDestinations",
                newName: "AirRouteID");

            migrationBuilder.RenameIndex(
                name: "IX_FlightDestinations_AirRoutesID",
                table: "FlightDestinations",
                newName: "IX_FlightDestinations_AirRouteID");

            migrationBuilder.RenameColumn(
                name: "CountryID",
                table: "Destination",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Destination_CountryID",
                table: "Destination",
                newName: "IX_Destination_CountryId");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Destination",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightDestinations_AirRoutes_AirRouteID",
                table: "FlightDestinations",
                column: "AirRouteID",
                principalTable: "AirRoutes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Country_CountryId",
                table: "Destination");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightDestinations_AirRoutes_AirRouteID",
                table: "FlightDestinations");

            migrationBuilder.RenameColumn(
                name: "AirRouteID",
                table: "FlightDestinations",
                newName: "AirRoutesID");

            migrationBuilder.RenameIndex(
                name: "IX_FlightDestinations_AirRouteID",
                table: "FlightDestinations",
                newName: "IX_FlightDestinations_AirRoutesID");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Destination",
                newName: "CountryID");

            migrationBuilder.RenameIndex(
                name: "IX_Destination_CountryId",
                table: "Destination",
                newName: "IX_Destination_CountryID");

            migrationBuilder.AlterColumn<int>(
                name: "CountryID",
                table: "Destination",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Country_CountryID",
                table: "Destination",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightDestinations_AirRoutes_AirRoutesID",
                table: "FlightDestinations",
                column: "AirRoutesID",
                principalTable: "AirRoutes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
