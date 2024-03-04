using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityPractice.Migrations
{
    /// <inheritdoc />
    public partial class staffandbuilding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Enrollments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeleNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingId);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StaffId",
                table: "Enrollments",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Staffs_StaffId",
                table: "Enrollments",
                column: "StaffId",
                principalTable: "Staffs",
                principalColumn: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Staffs_StaffId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StaffId",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Enrollments");
        }
    }
}
