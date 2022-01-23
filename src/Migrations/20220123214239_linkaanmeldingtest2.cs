using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class linkaanmeldingtest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Aanmelding_UserId",
                table: "Aanmelding");

            migrationBuilder.CreateIndex(
                name: "IX_Aanmelding_UserId",
                table: "Aanmelding",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Aanmelding_UserId",
                table: "Aanmelding");

            migrationBuilder.CreateIndex(
                name: "IX_Aanmelding_UserId",
                table: "Aanmelding",
                column: "UserId");
        }
    }
}
