using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.Relantionships.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Users_UserId",
                table: "UserInformations");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Users_UserId",
                table: "UserInformations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInformations_Users_UserId",
                table: "UserInformations");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInformations_Users_UserId",
                table: "UserInformations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
