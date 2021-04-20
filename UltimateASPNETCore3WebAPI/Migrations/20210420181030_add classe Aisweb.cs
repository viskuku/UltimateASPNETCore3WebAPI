using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UltimateASPNETCore3WebAPI.Migrations
{
    public partial class addclasseAisweb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8850a6c3-25dd-46c5-87be-4532a4ecfe14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89bcefe4-f42d-463c-9174-5adbf8b65875");

            migrationBuilder.CreateTable(
                name: "Aisweb",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    N = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    B = table.Column<int>(type: "int", nullable: false),
                    C = table.Column<int>(type: "int", nullable: false),
                    D = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    G = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Geo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Traffic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lower = table.Column<int>(type: "int", nullable: false),
                    Upper = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seqnumber = table.Column<int>(type: "int", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aisweb", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bb6550e-ed64-4855-b41e-e60309594f7e", "aedd0b86-4f23-43eb-a531-5d313f2cb8d2", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a0993b4-b6b4-4f04-a686-8bb6431c5af4", "756b9cf5-236a-4a4c-9bcc-15c6ffd3c7d8", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aisweb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a0993b4-b6b4-4f04-a686-8bb6431c5af4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bb6550e-ed64-4855-b41e-e60309594f7e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8850a6c3-25dd-46c5-87be-4532a4ecfe14", "e1749687-6b48-4a28-90d8-e6c8cf6778b3", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89bcefe4-f42d-463c-9174-5adbf8b65875", "9a06deb6-11df-4b4a-9afe-84982afe978a", "Administrator", "ADMINISTRATOR" });
        }
    }
}
