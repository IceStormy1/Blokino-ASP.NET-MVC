using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserRate",
                columns: table => new
                {
                    IdNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    IdFilm = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    RateFilm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRate", x => x.IdNumber);
                    table.ForeignKey(
                        name: "FK_UserRate_ServiceItems_IdFilm",
                        column: x => x.IdFilm,
                        principalTable: "ServiceItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRate_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "7e81a703-668b-4811-babd-328572ada242");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "0ad9f4a6-e4d9-4221-8922-e02d2fef134a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "14d4eb12-5f60-4a99-8306-b567ddd81e71", "IdentityUser", "AQAAAAEAACcQAAAAEOfkUfqTKrgxV1cIUiN5stmRqtLu3MCyubWBp/PdCQ2XS+I9XwyAvqnq3Zq+o4aKLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "a5c47068-5cc0-48fc-b2ff-3306256ee37e", "IdentityUser", "AQAAAAEAACcQAAAAEHY5++0EX1l2t5QxYU4bH82fczeJ9u0z8myxuMSPTPw0pnCAEyEv04XbYJURWUwJPw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 13, 15, 28, 0, 769, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 13, 15, 28, 0, 769, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 13, 15, 28, 0, 769, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_IdFilm",
                table: "UserRate",
                column: "IdFilm");

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_UsersId",
                table: "UserRate",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "4c505ae2-638b-4baa-bda2-598ef1ecb2c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "bbc50e53-ae6f-4c76-8d37-506e84633e58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "baa90518-bdf7-4f11-b917-54a9a0c3ac8a", "AQAAAAEAACcQAAAAEIL2cVszM42bASmtzM6IKl3vioo4a9MaRYpqDGWHdOozSAzCaXCgEcbYCC/D7uL9lA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "64a38ec1-6b82-4736-90cc-925d3c8c7f6e", "AQAAAAEAACcQAAAAEK6IxyQykiuD8fQVZ4b9Pv6HfL7qs4AGZsL2H10FonocmrPh6MBWEPKY2X8KEjARSQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 13, 14, 47, 40, 659, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 13, 14, 47, 40, 659, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 13, 14, 47, 40, 659, DateTimeKind.Utc).AddTicks(3936));
        }
    }
}
