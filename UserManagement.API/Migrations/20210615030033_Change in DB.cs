using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.API.Migrations
{
    public partial class ChangeinDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserMasters",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserMasters",
                newName: "Id");
        }
    }
}
