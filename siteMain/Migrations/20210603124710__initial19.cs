using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRateFilms",
                columns: table => new
                {
                    IdNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsersId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    IdActor = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    RateActor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRateFilms", x => x.IdNumber);
                    table.ForeignKey(
                        name: "FK_UserRateFilms_Actors_IdActor",
                        column: x => x.IdActor,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRateFilms_AspNetUsers_UsersId",
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
                value: "3b233d6e-a1e7-46cf-9e28-9c182906ec12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "ac625ad3-137b-4d6d-aeab-990368290383");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d75a613-3f8d-4cf7-bf02-1fb842b7d7f8", "AQAAAAEAACcQAAAAEJa9S1d80W+IJR6yy8McLlU/ombdUavotPD/sOCQFphJlNFJN4cWgO2TEm/Xk/3FAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1772c6e-f7f1-4a4a-809b-059760c23588", "AQAAAAEAACcQAAAAEHvR0xfKXt/jQlII3ad4DPQC1emS3FO1b+6GauTbNzEUvl1Nuhc4a9W0gC4FwtXKEw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 12, 47, 9, 969, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 12, 47, 9, 969, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 12, 47, 9, 969, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.CreateIndex(
                name: "IX_UserRateFilms_IdActor",
                table: "UserRateFilms",
                column: "IdActor");

            migrationBuilder.CreateIndex(
                name: "IX_UserRateFilms_UsersId",
                table: "UserRateFilms",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRateFilms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ee926e78-6c05-4a93-b030-cad44db6c6be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "5fc5cf88-2a12-42fb-8ec4-c25ff2da8092");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c397fdab-8228-4787-b7ce-7998c0817af7", "AQAAAAEAACcQAAAAEFgi1SnlTN8znu1jnT4kjhMTzZNInPZj06n5jYnA87NK7nQlaOvxKmhFl8pzaQlgJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9be2a90f-bd20-4722-9ecd-10f15f1d8169", "AQAAAAEAACcQAAAAEMDcz/2RsFf6OF89OfebGfs+Jp3nhS+6fizxix+1sUYdvMAXJDCrH7Q/ZeqYWfqzqA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 22, 15, 8, 9, 96, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 22, 15, 8, 9, 96, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 22, 15, 8, 9, 96, DateTimeKind.Utc).AddTicks(9816));
        }
    }
}
