using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class hulpverlener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hulpverlener",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    naam = table.Column<string>(type: "TEXT", nullable: true),
                    achternaam = table.Column<string>(type: "TEXT", nullable: true),
                    specialiteit = table.Column<string>(type: "TEXT", nullable: true),
                    beschrijving = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hulpverlener", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hulpverlener");
        }
    }
}
