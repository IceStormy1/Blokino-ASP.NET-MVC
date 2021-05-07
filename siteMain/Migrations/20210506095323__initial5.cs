using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "e07f5e77-7730-447d-b3e3-e62c2486a88a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "5a266125-9a27-4879-aa58-41004cfa027f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a9ef69e-5918-4564-b176-2f49d7954089", "AQAAAAEAACcQAAAAELa7O8NdkfVSfNsvr6WxPLsoSM4JjlAAn2o8JGc04xwmzBDnqV7fHQ/6FnQc2IuFDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e2ad32d-817c-4fbf-9ff7-cc4a5b7a5766", "AQAAAAEAACcQAAAAED1y86bd0Cngl69q4ntLbsyEO4kC93MJOwjK1tt0nVOf40viRyPfHEwTfmI0RHlAnA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 6, 9, 53, 22, 931, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 6, 9, 53, 22, 931, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 6, 9, 53, 22, 931, DateTimeKind.Utc).AddTicks(3340));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
