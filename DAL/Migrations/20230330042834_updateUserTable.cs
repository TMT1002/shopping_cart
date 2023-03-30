using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Users_userid",
                table: "Tokens");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "Tokens",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Tokens_userid",
                table: "Tokens",
                newName: "IX_Tokens_userId");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Tokens",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Users_userId",
                table: "Tokens",
                column: "userId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tokens_Users_userId",
                table: "Tokens");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Tokens",
                newName: "userid");

            migrationBuilder.RenameIndex(
                name: "IX_Tokens_userId",
                table: "Tokens",
                newName: "IX_Tokens_userid");

            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "Tokens",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Tokens_Users_userid",
                table: "Tokens",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
