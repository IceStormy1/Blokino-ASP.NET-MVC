using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdFilm",
                table: "UserRate");

            migrationBuilder.AddColumn<int>(
                name: "IdNumber",
                table: "UserRate",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserRate",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceItemId",
                table: "UserRate",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRate",
                table: "UserRate",
                column: "IdNumber");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_ServiceItemId",
                table: "UserRate",
                column: "ServiceItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRate_ServiceItems_ServiceItemId",
                table: "UserRate",
                column: "ServiceItemId",
                principalTable: "ServiceItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRate_ServiceItems_ServiceItemId",
                table: "UserRate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRate",
                table: "UserRate");

            migrationBuilder.DropIndex(
                name: "IX_UserRate_ServiceItemId",
                table: "UserRate");

            migrationBuilder.DropColumn(
                name: "IdNumber",
                table: "UserRate");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRate");

            migrationBuilder.DropColumn(
                name: "ServiceItemId",
                table: "UserRate");

            migrationBuilder.AddColumn<Guid>(
                name: "IdFilm",
                table: "UserRate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
