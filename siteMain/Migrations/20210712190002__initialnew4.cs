using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initialnew4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameActor",
                table: "FilmsAndActors");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "FilmsAndActors");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "75863d06-6073-4eeb-b8df-5d7c2da49776");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "739a6e37-5f1d-49ff-864f-d74f217fc20c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e247bd1-4817-476c-8543-41de13468e49", "AQAAAAEAACcQAAAAELBhW1qjVX76HeTUADwMNi4ErwVLFaOD5Pcnml5QkhiPmVGSkahzUvLDbhJJawdIgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3046f646-4dbd-4f78-9861-5c22319bbf4d", "AQAAAAEAACcQAAAAEFwpBQY0VnGU/cGAzvCCajHbEzhhlDWzAyViYf1982Wru9L27hxHKGTwxsSvLuftaA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 19, 0, 1, 789, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 19, 0, 1, 789, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 19, 0, 1, 789, DateTimeKind.Utc).AddTicks(8199));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameActor",
                table: "FilmsAndActors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "FilmsAndActors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a077dec1-5231-4124-ac58-cdab75466864");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "e0c9aab3-f3b8-4dfe-a7a5-2a7084dda3bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8f4eec2-ba9d-480d-91cb-3bcbcaba0373", "AQAAAAEAACcQAAAAEPwkGgxI3GwpdVs9KgVoiGtvI7avMfGqLWV6f6ZpH/Dw3kYmJG8mW2K1fyedQPNp4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fb37593-8d6d-473a-b06b-0904c756641e", "AQAAAAEAACcQAAAAEBI3eW78IHbFrkvUlB/TCsDNc98spbtvCFjQ8pEEtO+DQUdjI4FEiZ2nEfl/HEIZTA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 18, 49, 55, 705, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 18, 49, 55, 705, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 18, 49, 55, 705, DateTimeKind.Utc).AddTicks(2122));
        }
    }
}
