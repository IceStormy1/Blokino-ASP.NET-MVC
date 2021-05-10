using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRate");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "338d0493-ea8f-4e18-a557-c7749e593a4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "04a7f97e-b3a1-42b1-b720-7aa5b5697e01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7d30448-33a9-413b-aeea-efb66ea69739", "AQAAAAEAACcQAAAAEAeXOT6A+6GsqEcvHs3krFayXwa1w6HGcvWho6hkGzs9GZw+ZrUGDCqOp4DHUkvutg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ea54ef7-90d5-4538-bf86-cfa495bd24f4", "AQAAAAEAACcQAAAAEMuIacRGA14sJ2iBAw6VCranc1VTsQBjcytNSfHKKiJQjTWloo1Oww8d/om/nKOqBg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 34, 57, 253, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 34, 57, 253, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 34, 57, 253, DateTimeKind.Utc).AddTicks(7600));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserRate",
                columns: table => new
                {
                    IdNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RateFilm = table.Column<int>(type: "int", nullable: false),
                    ServiceItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRate", x => x.IdNumber);
                    table.ForeignKey(
                        name: "FK_UserRate_ServiceItems_ServiceItemId",
                        column: x => x.ServiceItemId,
                        principalTable: "ServiceItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRate_AspNetUsers_UsersId1",
                        column: x => x.UsersId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "5d745a25-1f0f-4460-b769-83379631ef8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "9c895a0c-2400-47ce-91eb-d668010ed6ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "4edcb031-cef4-4774-b863-bb9fd986774c", "IdentityUser", "AQAAAAEAACcQAAAAEAGWa2G1pJvgSGGFyyQssEHH9El19YoBjpWwdeprx6m3LyvLpjvZsEJ3tUrVhh2XfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "60e068f8-f2cf-4328-bd84-3a1fcf2f1137", "IdentityUser", "AQAAAAEAACcQAAAAEORj/c2WSA/0k62W4JREExRk2lopOI3e4Gn/3nCYGF/LnsrSnUEFXdPfZV1ivLlG9Q==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 25, 25, 335, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 25, 25, 335, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 25, 25, 335, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_ServiceItemId",
                table: "UserRate",
                column: "ServiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_UsersId1",
                table: "UserRate",
                column: "UsersId1");
        }
    }
}
