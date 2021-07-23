using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "AvgRateActor",
                table: "Actors",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "393fcdf9-a87b-4104-a507-37720cb9c5c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "46aea367-d113-4bd2-8e08-3c747434f942");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57ccc865-187f-465e-9819-e113befe7bdb", "AQAAAAEAACcQAAAAEMPwElplx6PEukXKVyfCLiQtclwlm2KShLX7qDWoOMNIPdKUCZxDp5xat6X7lPPC7w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "89081fc3-d8c3-4dab-8859-7cc71681f261", "AQAAAAEAACcQAAAAENJ5hLYOtwp4KMP71juRdAMBSnL8eH5SQEOnrwY+nhWlTh36CreVDbY3aWfYPUUPIQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 23, 12, 20, 8, 715, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 23, 12, 20, 8, 714, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 23, 12, 20, 8, 715, DateTimeKind.Utc).AddTicks(583));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "AvgRateActor",
                table: "Actors",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "eff6ef2b-2773-49ac-9c30-61deb23baed2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "ddc7a4ba-dfde-410b-a5c4-b6fadaf6b8da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7235f35-81c4-4446-b903-7d1790383c16", "AQAAAAEAACcQAAAAENvpB830QwjLIcFqAaB3qx5iVDK3RyJjO8hK/v0CTANHVS2paePcMrWJcFofT59w8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b478086-c6ea-4c21-94dd-d681260bc652", "AQAAAAEAACcQAAAAEDTrZGqL87E5J+wOTRZWIX3GqIlYHP43Yupv1RNgs+LOICZoD2TjRVbJ0HNbdhJwsQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 13, 8, 50, 15, 444, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 13, 8, 50, 15, 444, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 13, 8, 50, 15, 444, DateTimeKind.Utc).AddTicks(2457));
        }
    }
}
