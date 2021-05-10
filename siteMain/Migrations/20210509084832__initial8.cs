using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRate",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    RateFilm = table.Column<int>(nullable: false),
                    IdFilm = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "6fa9007d-0733-402d-b1e0-6f0d5efac121");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "1cd04113-a83e-4344-9b7f-37102256a8f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "716b9f05-f275-479c-a413-39d8d209809a", "AQAAAAEAACcQAAAAED3y4pukzlgOa4EHf//Yb1gULi1Yq+Ue/evZNjLVl8cbR1nv6vK/SuYd1vcsLx+YNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1e810f8-3938-4488-a159-8a6ba4ba4e94", "AQAAAAEAACcQAAAAEGtkGgvLCCL7xItyGUYDCZmL7h5xMK/V9eYu4etvWcguNf/QNnUzkG+qiOrNkbh52g==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 8, 48, 32, 247, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 8, 48, 32, 247, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 8, 48, 32, 247, DateTimeKind.Utc).AddTicks(7401));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "e771a448-48c9-4947-9eda-440c52ac7585");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "56130a04-8e3f-4122-83f6-32dd5c1d5945");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce59f943-19d1-4cb8-a990-863fe6237df8", "AQAAAAEAACcQAAAAEHFGHIl2nbQHkLx7LD0ajH52NIStgLqckGjKHwGuK4FPk/N5Cz0fEVYZQEeS7jVacA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30cdf33a-f6b4-40d4-9360-c4639b6a01ee", "AQAAAAEAACcQAAAAEJMHTTb7B6d9P+/hLNd+ID6EscgTdhRuZsuf+dPFIwuL/+J6PvDhTlX0l008j2qsGA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 8, 41, 45, 932, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 8, 41, 45, 931, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 8, 41, 45, 931, DateTimeKind.Utc).AddTicks(9963));
        }
    }
}
