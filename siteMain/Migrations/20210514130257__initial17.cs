using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RateUsers",
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
                    table.PrimaryKey("PK_RateUsers", x => x.IdNumber);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "89f8260a-013b-44e5-a88c-b17795a4fa5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "9d2d8732-38c2-4a42-90f3-5ed85f977ed9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3daf19cf-8492-481a-bf06-1005d0f29046", "AQAAAAEAACcQAAAAECHxwRUehzA+HzLvZdebQJ38eW73RYhHFtpe83k5bz/pNH7Ce5NI6d+XaRy31u9YIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c000e066-76de-4925-8cea-c641b289b06c", "AQAAAAEAACcQAAAAEKyWLH28/i3K58LjON7NelVvUhfRlDI3hjYbOuwQxqYtPBCTSWCDGkO5e2+JgUmcaQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 14, 13, 2, 57, 88, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 14, 13, 2, 57, 88, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 14, 13, 2, 57, 88, DateTimeKind.Utc).AddTicks(5422));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RateUsers");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14d4eb12-5f60-4a99-8306-b567ddd81e71", "AQAAAAEAACcQAAAAEOfkUfqTKrgxV1cIUiN5stmRqtLu3MCyubWBp/PdCQ2XS+I9XwyAvqnq3Zq+o4aKLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5c47068-5cc0-48fc-b2ff-3306256ee37e", "AQAAAAEAACcQAAAAEHY5++0EX1l2t5QxYU4bH82fczeJ9u0z8myxuMSPTPw0pnCAEyEv04XbYJURWUwJPw==" });

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
        }
    }
}
