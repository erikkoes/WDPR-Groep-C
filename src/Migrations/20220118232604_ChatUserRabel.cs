using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class ChatUserRabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersJSON",
                table: "Rooms");

            migrationBuilder.CreateTable(
                name: "ChatUser",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatUser", x => new { x.UserId, x.RoomId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatUser");

            migrationBuilder.AddColumn<string>(
                name: "UsersJSON",
                table: "Rooms",
                type: "TEXT",
                nullable: true);
        }
    }
}
