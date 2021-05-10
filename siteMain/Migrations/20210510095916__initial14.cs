using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "UserRate",
                columns: table => new
                {
                    IdNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    ServiceItemId = table.Column<Guid>(nullable: true),
                    RateFilm = table.Column<int>(nullable: false),
                    
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRate", x => x.IdNumber);
                    table.ForeignKey(
                        name: "FK_UserRate_ServiceItems_ServiceItemId",
                        column: x => x.ServiceItemId,
                        principalTable: "ServiceItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRate_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "96ac746d-f789-4394-8876-d488bc541e25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "44ae0f8d-36d4-4d7d-b2a1-6a0705cf25f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "8396d4f3-d846-4f86-92a9-e3e9676c4f48", "IdentityUser", "AQAAAAEAACcQAAAAEKtpxtEn6gqa+vLQ1TZjP21x8uMXVnSph7UEwGwaYPP6T3lhw5vkrW2XN7FGKSidZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "2e291372-8f56-40cc-b3d2-1700da693974", "IdentityUser", "AQAAAAEAACcQAAAAEIdae47+ZLvJyBoTKf39Utkl+NDA6wkAeMyWoGiR8PmLrEW8CFIU3iWrEEmmDzufOA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 59, 15, 608, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 59, 15, 608, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 59, 15, 608, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_ServiceItemId",
                table: "UserRate",
                column: "ServiceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRate_UsersId",
                table: "UserRate",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRate");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "338d0493-ea8f-4e18-a557-c7749e593a4e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "04a7f97e-b3a1-42b1-b720-7aa5b5697e01");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7d30448-33a9-413b-aeea-efb66ea69739", "AQAAAAEAACcQAAAAEAeXOT6A+6GsqEcvHs3krFayXwa1w6HGcvWho6hkGzs9GZw+ZrUGDCqOp4DHUkvutg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ea54ef7-90d5-4538-bf86-cfa495bd24f4", "AQAAAAEAACcQAAAAEMuIacRGA14sJ2iBAw6VCranc1VTsQBjcytNSfHKKiJQjTWloo1Oww8d/om/nKOqBg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 34, 57, 253, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 34, 57, 253, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 10, 9, 34, 57, 253, DateTimeKind.Utc).AddTicks(7600));
        }
    }
}
