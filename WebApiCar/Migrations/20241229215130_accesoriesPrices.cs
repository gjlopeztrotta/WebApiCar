using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCar.Migrations
{
    /// <inheritdoc />
    public partial class accesoriesPrices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarAccesoriesPricesId",
                table: "CarAccesories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarAccesoriesPrices",
                columns: table => new
                {
                    CarAccesoriesPricesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CarAccesoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAccesoriesPrices", x => x.CarAccesoriesPricesId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarAccesories_CarAccesoriesPrices_CarAccesoriesPricesId",
                table: "CarAccesories");

            migrationBuilder.DropTable(
                name: "CarAccesoriesPrices");

            migrationBuilder.DropIndex(
                name: "IX_CarAccesories_CarAccesoriesPricesId",
                table: "CarAccesories");

            migrationBuilder.DropColumn(
                name: "CarAccesoriesPricesId",
                table: "CarAccesories");
        }
    }
}
