using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tumin.Cargo.DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CargoDetails_CargoCustomers_CargoCustomerId",
                table: "CargoDetails");

            migrationBuilder.DropIndex(
                name: "IX_CargoDetails_CargoCustomerId",
                table: "CargoDetails");

            migrationBuilder.DropColumn(
                name: "CargoCustomerId",
                table: "CargoDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CargoCustomerId",
                table: "CargoDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CargoDetails_CargoCustomerId",
                table: "CargoDetails",
                column: "CargoCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CargoDetails_CargoCustomers_CargoCustomerId",
                table: "CargoDetails",
                column: "CargoCustomerId",
                principalTable: "CargoCustomers",
                principalColumn: "CargoCustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
