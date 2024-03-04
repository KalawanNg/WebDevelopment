using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityPractice.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipbetweenUserIdandMembership : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Memberships",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_IdentityUserId",
                table: "Memberships",
                column: "IdentityUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Memberships_AspNetUsers_IdentityUserId",
                table: "Memberships",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Memberships_AspNetUsers_IdentityUserId",
                table: "Memberships");

            migrationBuilder.DropIndex(
                name: "IX_Memberships_IdentityUserId",
                table: "Memberships");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Memberships");
        }
    }
}
