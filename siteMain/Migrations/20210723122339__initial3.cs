using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "AvgRateFilm",
                table: "Films",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "e7616669-514e-4774-a921-97db0a6640c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "7e67d34e-44a5-49ef-9040-113906146843");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b736c425-6e4f-49c9-af8f-b72b8c8bbce5", "AQAAAAEAACcQAAAAELGzPpNrodwDbxePaBXB334hmGwTwKpMhI+mmGtoAilvx5uHcrzJ+BSpTVo8TCE3DQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d0df725-c5d3-4840-9db3-26109bcc2529", "AQAAAAEAACcQAAAAEMJ9eOmuKGDAmce8O61ABjytoMmgdUBbXXNIACwsbtJSQckkIDCl2XBmRFaqnP937A==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 23, 12, 23, 39, 368, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 23, 12, 23, 39, 367, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 7, 23, 12, 23, 39, 368, DateTimeKind.Utc).AddTicks(520));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "AvgRateFilm",
                table: "Films",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

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
    }
}
