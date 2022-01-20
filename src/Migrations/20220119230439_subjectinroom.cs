using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class subjectinroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatUser_Rooms_ChatId",
                table: "ChatUser");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ChatId",
                table: "ChatUser",
                newName: "ChatRoomId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatUser_ChatId",
                table: "ChatUser",
                newName: "IX_ChatUser_ChatRoomId");

            migrationBuilder.AddColumn<string>(
                name: "RoomSubject",
                table: "Rooms",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChatRoomId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatRoomId",
                table: "Messages",
                column: "ChatRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUser_Rooms_ChatRoomId",
                table: "ChatUser",
                column: "ChatRoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Rooms_ChatRoomId",
                table: "Messages",
                column: "ChatRoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatUser_Rooms_ChatRoomId",
                table: "ChatUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Rooms_ChatRoomId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ChatRoomId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "RoomSubject",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ChatRoomId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "ChatRoomId",
                table: "ChatUser",
                newName: "ChatId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatUser_ChatRoomId",
                table: "ChatUser",
                newName: "IX_ChatUser_ChatId");

            migrationBuilder.AddColumn<string>(
                name: "ChatId",
                table: "Messages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUser_Rooms_ChatId",
                table: "ChatUser",
                column: "ChatId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
