using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class ChatSender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Rooms_ChatRoomId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ChatRoomId",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Messages",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Messages",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MessageModelId",
                table: "ChatUser",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChatUser_MessageModelId",
                table: "ChatUser",
                column: "MessageModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatUser_Messages_MessageModelId",
                table: "ChatUser",
                column: "MessageModelId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatUser_Messages_MessageModelId",
                table: "ChatUser");

            migrationBuilder.DropIndex(
                name: "IX_ChatUser_MessageModelId",
                table: "ChatUser");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageModelId",
                table: "ChatUser");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Messages",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatRoomId",
                table: "Messages",
                column: "ChatRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Rooms_ChatRoomId",
                table: "Messages",
                column: "ChatRoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
