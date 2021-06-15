using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.API.Migrations
{
    public partial class AddedPasswordfieldforauthentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserMasters",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserMasters");
        }
    }
}
