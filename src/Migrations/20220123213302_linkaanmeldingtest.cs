using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class linkaanmeldingtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caregiver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    UserId1 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caregiver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caregiver_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Caregiver_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aanmelding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CaregiverId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aanmelding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aanmelding_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aanmelding_Caregiver_CaregiverId",
                        column: x => x.CaregiverId,
                        principalTable: "Caregiver",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aanmelding_CaregiverId",
                table: "Aanmelding",
                column: "CaregiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Aanmelding_UserId",
                table: "Aanmelding",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Caregiver_UserId",
                table: "Caregiver",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Caregiver_UserId1",
                table: "Caregiver",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aanmelding");

            migrationBuilder.DropTable(
                name: "Caregiver");
        }
    }
}
