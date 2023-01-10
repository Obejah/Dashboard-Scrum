using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboardscrum.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3f576b5a-7309-4613-9c1c-040794789a15");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9f5af696-90b7-4471-a89a-312a59cf9416");

            migrationBuilder.DropColumn(
                name: "Gebruikerrol",
                table: "User");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "611eb8a1-8ff5-4375-9ca3-2e83a70a63e6", null, "Docent", "DOCENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1a96f70-ba30-4b44-a534-beafd87186c4", null, "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "611eb8a1-8ff5-4375-9ca3-2e83a70a63e6");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f1a96f70-ba30-4b44-a534-beafd87186c4");

            migrationBuilder.AddColumn<int>(
                name: "Gebruikerrol",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f576b5a-7309-4613-9c1c-040794789a15", null, "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f5af696-90b7-4471-a89a-312a59cf9416", null, "Docent", "DOCENT" });
        }
    }
}
