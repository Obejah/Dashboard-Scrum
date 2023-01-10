using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboardscrum.Migrations
{
    public partial class BigGBejah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "34314493-34e2-4697-9494-df0c9f95df47");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ed1cfb64-29c5-4c1f-bc35-ddff4a96943c");

            migrationBuilder.AddColumn<int>(
                name: "Aanwezigheid",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TeamId",
                table: "User",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c252664d-7bfd-4203-bb35-80be98038daa", null, "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9aaa175-b39c-4ede-a61c-2476148f7d2e", null, "Docent", "DOCENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c252664d-7bfd-4203-bb35-80be98038daa");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d9aaa175-b39c-4ede-a61c-2476148f7d2e");

            migrationBuilder.DropColumn(
                name: "Aanwezigheid",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "User");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34314493-34e2-4697-9494-df0c9f95df47", null, "Docent", "DOCENT" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed1cfb64-29c5-4c1f-bc35-ddff4a96943c", null, "Student", "STUDENT" });
        }
    }
}
