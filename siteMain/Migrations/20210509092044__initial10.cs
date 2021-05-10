using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "UserRate",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "446e5d14-6973-4960-84eb-41717d1d4a1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "7ae30bed-b8bb-4056-a199-1f4c797a7467");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "d75bd135-ded7-4939-b719-fe0d7720e7c3", "IdentityUser", "AQAAAAEAACcQAAAAEIp3bpOEybEqnxducgoUq24/8OQKZwTykXFdCN4kZzS/4x8GEZzyrx9noLk/d6M7Xw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "dff09ee6-369d-417b-996c-7d2f3136075e", "IdentityUser", "AQAAAAEAACcQAAAAEHgdDJvSV7+4G3LgDSZyhpKYejrGsf/0vFcwTSKE0lpasZyDpkxlHJ+Fp/ZdjriS9g==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 9, 20, 44, 50, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 9, 20, 44, 50, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 9, 20, 44, 50, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_UsersId",
                table: "UserRate",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRate_AspNetUsers_UsersId",
                table: "UserRate",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRate_AspNetUsers_UsersId",
                table: "UserRate");

            migrationBuilder.DropIndex(
                name: "IX_UserRate_UsersId",
                table: "UserRate");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "UserRate");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4de7dd03-ee24-463d-a6a2-fac4c2b90c8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "ab7dd715-6837-4313-837f-245e7217db93");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbe0a1cd-082c-4027-bb44-df5da8a49940", "AQAAAAEAACcQAAAAELyMD3ZogSatWSBbN70ENpRkCN0okQ9HxSswd/fcUsUQOgjMusSQsuwrIyLLxnhHNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d4e9fa8-ea5f-4a37-b0de-d30dba2d5615", "AQAAAAEAACcQAAAAEBzEMgjLGNqu8A9QQMUgLHKq9HvhsqHFvZ9YqkDPhMpVfsLg5WLzYyxkpbkkDnYCew==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 9, 14, 7, 65, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 9, 14, 7, 65, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 9, 9, 14, 7, 65, DateTimeKind.Utc).AddTicks(6126));
        }
    }
}
