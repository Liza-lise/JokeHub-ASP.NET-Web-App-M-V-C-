using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jokes_APP_ASP.NET_CORE_WE_APP__mvc_.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddJokeCreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Jokes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jokes_CreatedByUserId",
                table: "Jokes",
                column: "CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jokes_AspNetUsers_CreatedByUserId",
                table: "Jokes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jokes_AspNetUsers_CreatedByUserId",
                table: "Jokes");

            migrationBuilder.DropIndex(
                name: "IX_Jokes_CreatedByUserId",
                table: "Jokes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Jokes");
        }
    }
}
