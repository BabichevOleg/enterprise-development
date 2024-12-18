using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarRentalApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<string>(type: "text", nullable: false),
                    model = table.Column<string>(type: "text", nullable: false),
                    color = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pusport_number = table.Column<int>(type: "integer", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    birth_date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RentalPlace",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalPlace", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RentedCar",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    car = table.Column<int>(type: "integer", nullable: false),
                    rentalPlace = table.Column<int>(type: "integer", nullable: false),
                    client = table.Column<int>(type: "integer", nullable: false),
                    issue_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    rental_period = table.Column<TimeSpan>(type: "interval", nullable: true),
                    return_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    returnRentalPlace = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentedCar", x => x.id);
                    table.ForeignKey(
                        name: "FK_RentedCar_Car_car",
                        column: x => x.car,
                        principalTable: "Car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentedCar_Client_client",
                        column: x => x.client,
                        principalTable: "Client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentedCar_RentalPlace_rentalPlace",
                        column: x => x.rentalPlace,
                        principalTable: "RentalPlace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentedCar_RentalPlace_returnRentalPlace",
                        column: x => x.returnRentalPlace,
                        principalTable: "RentalPlace",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RentedCar_car",
                table: "RentedCar",
                column: "car");

            migrationBuilder.CreateIndex(
                name: "IX_RentedCar_client",
                table: "RentedCar",
                column: "client");

            migrationBuilder.CreateIndex(
                name: "IX_RentedCar_rentalPlace",
                table: "RentedCar",
                column: "rentalPlace");

            migrationBuilder.CreateIndex(
                name: "IX_RentedCar_returnRentalPlace",
                table: "RentedCar",
                column: "returnRentalPlace");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentedCar");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "RentalPlace");
        }
    }
}
