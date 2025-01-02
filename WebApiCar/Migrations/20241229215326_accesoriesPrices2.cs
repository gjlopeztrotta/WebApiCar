using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCar.Migrations
{
    /// <inheritdoc />
    public partial class accesoriesPrices2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarAccesories_CarAccesoriesPrices_CarAccesoriesPricesId",
                table: "CarAccesories");

            migrationBuilder.DropIndex(
                name: "IX_CarAccesories_CarAccesoriesPricesId",
                table: "CarAccesories");

            migrationBuilder.AddColumn<int>(
                name: "CarAccesoriesPricesId1",
                table: "CarAccesories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarAccesories_CarAccesoriesPricesId1",
                table: "CarAccesories",
                column: "CarAccesoriesPricesId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CarAccesories_CarAccesoriesPrices_CarAccesoriesPricesId1",
                table: "CarAccesories",
                column: "CarAccesoriesPricesId1",
                principalTable: "CarAccesoriesPrices",
                principalColumn: "CarAccesoriesPricesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarAccesories_CarAccesoriesPrices_CarAccesoriesPricesId1",
                table: "CarAccesories");

            migrationBuilder.DropIndex(
                name: "IX_CarAccesories_CarAccesoriesPricesId1",
                table: "CarAccesories");

            migrationBuilder.DropColumn(
                name: "CarAccesoriesPricesId1",
                table: "CarAccesories");

            migrationBuilder.CreateIndex(
                name: "IX_CarAccesories_CarAccesoriesPricesId",
                table: "CarAccesories",
                column: "CarAccesoriesPricesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarAccesories_CarAccesoriesPrices_CarAccesoriesPricesId",
                table: "CarAccesories",
                column: "CarAccesoriesPricesId",
                principalTable: "CarAccesoriesPrices",
                principalColumn: "CarAccesoriesPricesId");
        }
    }
}
