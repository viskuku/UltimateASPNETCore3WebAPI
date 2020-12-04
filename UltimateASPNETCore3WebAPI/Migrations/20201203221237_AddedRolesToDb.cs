using Microsoft.EntityFrameworkCore.Migrations;

namespace UltimateASPNETCore3WebAPI.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8850a6c3-25dd-46c5-87be-4532a4ecfe14", "e1749687-6b48-4a28-90d8-e6c8cf6778b3", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89bcefe4-f42d-463c-9174-5adbf8b65875", "9a06deb6-11df-4b4a-9afe-84982afe978a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8850a6c3-25dd-46c5-87be-4532a4ecfe14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89bcefe4-f42d-463c-9174-5adbf8b65875");
        }
    }
}
