using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initialnew2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "UserRatesActors");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserRatesActors");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "UserRateFilms");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserRateFilms");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "UserRatesActors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserRatesActors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "UserRateFilms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserRateFilms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "9524a3cf-ea56-4ee3-93b4-41c0be3df5dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "8a9b5ba9-bebd-4006-92c6-e044be3aa40b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4fb21b7-3c5e-4445-890c-90deb448769f", "AQAAAAEAACcQAAAAEOytdEoKkQqYmpZ9AAzT9kPmQvthrDRSGeakaKMa+iW7uZM8BZpPBizu8PSyikaj4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8282bb4f-5712-46ef-8070-71c5996879be", "AQAAAAEAACcQAAAAEM9hJITMyT7bElY+wKbW7s2jC2i5H5ymockFDY5/HSyo7laGn1GjFjHmOLaRaUneHQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 18, 36, 21, 163, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 18, 36, 21, 163, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 12, 18, 36, 21, 163, DateTimeKind.Utc).AddTicks(7549));
        }
    }
}
