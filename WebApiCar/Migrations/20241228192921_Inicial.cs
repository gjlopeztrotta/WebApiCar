using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCar.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarAccesories",
                columns: table => new
                {
                    CarAccesoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccesoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccesoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAccesories", x => x.CarAccesoriesId);
                });

            migrationBuilder.CreateTable(
                name: "CarOptions",
                columns: table => new
                {
                    CarOptionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOptions", x => x.CarOptionsId);
                });

            migrationBuilder.CreateTable(
                name: "CarsPrices",
                columns: table => new
                {
                    CarPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Totalprice = table.Column<double>(type: "float", nullable: false),
                    IVA = table.Column<double>(type: "float", nullable: false),
                    IGIC = table.Column<double>(type: "float", nullable: false),
                    Listprice = table.Column<double>(type: "float", nullable: false),
                    carId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsPrices", x => x.CarPriceId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    carId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    familia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarPriceId = table.Column<int>(type: "int", nullable: false),
                    CarPriceId1 = table.Column<int>(type: "int", nullable: false),
                    decripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.carId);
                    table.ForeignKey(
                        name: "FK_Cars_CarsPrices_CarPriceId1",
                        column: x => x.CarPriceId1,
                        principalTable: "CarsPrices",
                        principalColumn: "CarPriceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarCarAccesories",
                columns: table => new
                {
                    AccesoriesCarAccesoriesId = table.Column<int>(type: "int", nullable: false),
                    CarscarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCarAccesories", x => new { x.AccesoriesCarAccesoriesId, x.CarscarId });
                    table.ForeignKey(
                        name: "FK_CarCarAccesories_CarAccesories_AccesoriesCarAccesoriesId",
                        column: x => x.AccesoriesCarAccesoriesId,
                        principalTable: "CarAccesories",
                        principalColumn: "CarAccesoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCarAccesories_Cars_CarscarId",
                        column: x => x.CarscarId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarCarOptions",
                columns: table => new
                {
                    CarscarId = table.Column<int>(type: "int", nullable: false),
                    OptionsCarOptionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCarOptions", x => new { x.CarscarId, x.OptionsCarOptionsId });
                    table.ForeignKey(
                        name: "FK_CarCarOptions_CarOptions_OptionsCarOptionsId",
                        column: x => x.OptionsCarOptionsId,
                        principalTable: "CarOptions",
                        principalColumn: "CarOptionsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCarOptions_Cars_CarscarId",
                        column: x => x.CarscarId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCarAccesories_CarscarId",
                table: "CarCarAccesories",
                column: "CarscarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarCarOptions_OptionsCarOptionsId",
                table: "CarCarOptions",
                column: "OptionsCarOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarPriceId1",
                table: "Cars",
                column: "CarPriceId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCarAccesories");

            migrationBuilder.DropTable(
                name: "CarCarOptions");

            migrationBuilder.DropTable(
                name: "CarAccesories");

            migrationBuilder.DropTable(
                name: "CarOptions");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarsPrices");
        }
    }
}
