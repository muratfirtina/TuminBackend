using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Tumin.Cargo.DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoCompanies",
                columns: table => new
                {
                    CargoCompanyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CargoCompanyName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoCompanies", x => x.CargoCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "CargoCustomers",
                columns: table => new
                {
                    CargoCustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CargoCustomerName = table.Column<string>(type: "text", nullable: false),
                    CargoCustomerSurname = table.Column<string>(type: "text", nullable: false),
                    CargoCustomerPhone = table.Column<string>(type: "text", nullable: false),
                    CargoCustomerEmail = table.Column<string>(type: "text", nullable: false),
                    CargoCustomerAddress = table.Column<string>(type: "text", nullable: false),
                    CargoCustomerCity = table.Column<string>(type: "text", nullable: false),
                    CargoCustomerCountry = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoCustomers", x => x.CargoCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CargoOperations",
                columns: table => new
                {
                    CargoOperationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CargoTrackingNumber = table.Column<string>(type: "text", nullable: false),
                    CargoOperationDescription = table.Column<string>(type: "text", nullable: false),
                    CargoOperationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoOperations", x => x.CargoOperationId);
                });

            migrationBuilder.CreateTable(
                name: "CargoDetails",
                columns: table => new
                {
                    CargoDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderCustomer = table.Column<string>(type: "text", nullable: false),
                    ReceiverCustomer = table.Column<string>(type: "text", nullable: false),
                    CargoCustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CargoCompanyId = table.Column<int>(type: "integer", nullable: false),
                    CargoTrackingNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoDetails", x => x.CargoDetailId);
                    table.ForeignKey(
                        name: "FK_CargoDetails_CargoCompanies_CargoCompanyId",
                        column: x => x.CargoCompanyId,
                        principalTable: "CargoCompanies",
                        principalColumn: "CargoCompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoDetails_CargoCustomers_CargoCustomerId",
                        column: x => x.CargoCustomerId,
                        principalTable: "CargoCustomers",
                        principalColumn: "CargoCustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoDetails_CargoCompanyId",
                table: "CargoDetails",
                column: "CargoCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoDetails_CargoCustomerId",
                table: "CargoDetails",
                column: "CargoCustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoDetails");

            migrationBuilder.DropTable(
                name: "CargoOperations");

            migrationBuilder.DropTable(
                name: "CargoCompanies");

            migrationBuilder.DropTable(
                name: "CargoCustomers");
        }
    }
}
