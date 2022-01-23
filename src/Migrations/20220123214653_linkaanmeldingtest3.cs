using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class linkaanmeldingtest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Aanmelding_CaregiverId",
                table: "Aanmelding");

            migrationBuilder.AddColumn<int>(
                name: "CaregiverId1",
                table: "Aanmelding",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aanmelding_CaregiverId",
                table: "Aanmelding",
                column: "CaregiverId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aanmelding_CaregiverId1",
                table: "Aanmelding",
                column: "CaregiverId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Aanmelding_Caregiver_CaregiverId1",
                table: "Aanmelding",
                column: "CaregiverId1",
                principalTable: "Caregiver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aanmelding_Caregiver_CaregiverId1",
                table: "Aanmelding");

            migrationBuilder.DropIndex(
                name: "IX_Aanmelding_CaregiverId",
                table: "Aanmelding");

            migrationBuilder.DropIndex(
                name: "IX_Aanmelding_CaregiverId1",
                table: "Aanmelding");

            migrationBuilder.DropColumn(
                name: "CaregiverId1",
                table: "Aanmelding");

            migrationBuilder.CreateIndex(
                name: "IX_Aanmelding_CaregiverId",
                table: "Aanmelding",
                column: "CaregiverId");
        }
    }
}
