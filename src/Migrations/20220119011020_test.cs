using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "ChatUser",
                newName: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatUser_ChatId",
                table: "ChatUser",
                column: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUser_AspNetUsers_UserId",
                table: "ChatUser",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUser_Rooms_ChatId",
                table: "ChatUser",
                column: "ChatId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatUser_AspNetUsers_UserId",
                table: "ChatUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatUser_Rooms_ChatId",
                table: "ChatUser");

            migrationBuilder.DropIndex(
                name: "IX_ChatUser_ChatId",
                table: "ChatUser");

            migrationBuilder.RenameColumn(
                name: "ChatId",
                table: "ChatUser",
                newName: "RoomId");
        }
    }
}
