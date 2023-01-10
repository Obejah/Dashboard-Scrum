using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboardscrum.Migrations
{
    public partial class o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c252664d-7bfd-4203-bb35-80be98038daa");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d9aaa175-b39c-4ede-a61c-2476148f7d2e");

            migrationBuilder.AddColumn<int>(
                name: "Gebruikerrol",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3780e65b-3f34-46d6-b7a7-148219886aa6", null, "Docent", "DOCENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab0f39df-b76c-47ea-9cab-d03b381d09b0", null, "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3780e65b-3f34-46d6-b7a7-148219886aa6");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ab0f39df-b76c-47ea-9cab-d03b381d09b0");

            migrationBuilder.DropColumn(
                name: "Gebruikerrol",
                table: "User");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c252664d-7bfd-4203-bb35-80be98038daa", null, "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9aaa175-b39c-4ede-a61c-2476148f7d2e", null, "Docent", "DOCENT" });
        }
    }
}
