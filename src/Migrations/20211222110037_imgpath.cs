using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class imgpath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imagePath",
                table: "Hulpverlener",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagePath",
                table: "Hulpverlener");
        }
    }
}
