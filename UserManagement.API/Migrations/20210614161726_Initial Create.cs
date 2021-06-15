using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCode = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMasters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserMasters",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName", "PCode" },
                values: new object[] { 1, "admin@test.com", "Admin", true, "Main", "HCL000" });

            migrationBuilder.InsertData(
                table: "UserMasters",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName", "PCode" },
                values: new object[] { 2, "Micky@test.com", "Micky", true, "Mouse", "HCL001" });

            migrationBuilder.InsertData(
                table: "UserMasters",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName", "PCode" },
                values: new object[] { 3, "Ben@test.com", "Ben", false, "Ten", "HCL002" });

            migrationBuilder.InsertData(
                table: "UserMasters",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName", "PCode" },
                values: new object[] { 4, "Choota@test.com", "Choota", true, "Bheen", "HCL031" });

            migrationBuilder.InsertData(
                table: "UserMasters",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName", "PCode" },
                values: new object[] { 5, "Paw@test.com", "Paw", false, "Patrol", "HCL042" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMasters");
        }
    }
}
