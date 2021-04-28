using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AllFilmsIdFilm",
                table: "UserRate",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "33442216-de4d-47ae-b866-a8cf97d78781");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "c5ed6857-dafc-4c9d-8b54-6a9ce20d3110");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c138988b-7d27-4cec-b72d-4bca03dc75d4", "AQAAAAEAACcQAAAAECP4GKoDCRPixifbT8Zshfaz+CusMOqJRi0K+LfMQP3vhrtGHLkFyUFO8wM/JAhgHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "982af87c-ab45-45f8-ae87-5f9514055abd", "AQAAAAEAACcQAAAAEM99YZvwmi/0xQqhfAePUrs+WS4oRMJba3lQh8CUUgULPFe5vMT7prEBtZEX3UqMAA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 16, 56, 40, 414, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 16, 56, 40, 414, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 16, 56, 40, 414, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_AllFilmsIdFilm",
                table: "UserRate",
                column: "AllFilmsIdFilm");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRate_AllFilms_AllFilmsIdFilm",
                table: "UserRate",
                column: "AllFilmsIdFilm",
                principalTable: "AllFilms",
                principalColumn: "IdFilm",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRate_AllFilms_AllFilmsIdFilm",
                table: "UserRate");

            migrationBuilder.DropIndex(
                name: "IX_UserRate_AllFilmsIdFilm",
                table: "UserRate");

            migrationBuilder.DropColumn(
                name: "AllFilmsIdFilm",
                table: "UserRate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "324cb551-dcab-45f6-b8c2-52805ceabf27");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "2058662d-615f-4371-8573-de68e8922a41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b9a6ee0-5025-4892-bc95-95ad61d3108e", "AQAAAAEAACcQAAAAELgQ0+9R+CM/UD2K3zHeUChI4DSnuJoqfhEPEKkuGdePdi1sj76tw2qxzV0ShTWpoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83f097b5-217f-425e-996c-ed61909d0b4e", "AQAAAAEAACcQAAAAELUQFrAitJ5yBweflL4T9A88xwsiroVd26WKgVFqyKWREG3CLMLzRD3lxDwHo+AlbQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 14, 52, 43, 314, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 14, 52, 43, 314, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 14, 52, 43, 314, DateTimeKind.Utc).AddTicks(2376));
        }
    }
}
