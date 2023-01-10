using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboardscrum.Migrations
{
    public partial class Winst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3780e65b-3f34-46d6-b7a7-148219886aa6");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ab0f39df-b76c-47ea-9cab-d03b381d09b0");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f576b5a-7309-4613-9c1c-040794789a15", null, "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f5af696-90b7-4471-a89a-312a59cf9416", null, "Docent", "DOCENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3f576b5a-7309-4613-9c1c-040794789a15");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9f5af696-90b7-4471-a89a-312a59cf9416");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3780e65b-3f34-46d6-b7a7-148219886aa6", null, "Docent", "DOCENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab0f39df-b76c-47ea-9cab-d03b381d09b0", null, "Student", "STUDENT" });
        }
    }
}
