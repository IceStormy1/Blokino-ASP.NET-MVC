using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRatesActors",
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
                    table.PrimaryKey("PK_UserRatesActors", x => x.IdNumber);
                    table.ForeignKey(
                        name: "FK_UserRatesActors_Actors_IdActor",
                        column: x => x.IdActor,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRatesActors_AspNetUsers_UsersId",
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
                value: "49b85e4b-f72b-42fa-9caa-1673c2cc8b6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "00eca9ca-c73e-432d-abe8-954ee9fec2a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b7d1864c-3da6-4a4a-af2a-6b8bf1a796c3", "AQAAAAEAACcQAAAAEI15gVKP4nMhyKX2MUHZAjAnCf9fc9Lu+uEOk9oLT+jqeoMruYE0qSsJyDjH+cc3qw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "debe59f4-af05-4830-b5b0-b1a77bccafe6", "AQAAAAEAACcQAAAAEHNnqEV+0o66kZpRQXfCEZWO+Vx6yctDKaA8EnmoIEjM8s86IfJz509NnnY6zzNAcg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 13, 28, 58, 947, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 13, 28, 58, 947, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 13, 28, 58, 947, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.CreateIndex(
                name: "IX_UserRatesActors_IdActor",
                table: "UserRatesActors",
                column: "IdActor");

            migrationBuilder.CreateIndex(
                name: "IX_UserRatesActors_UsersId",
                table: "UserRatesActors",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRatesActors");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c77a27bd-fe50-4d13-821d-f7f507e631e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "6d9c82d9-1991-4f9e-9538-0597343aeea8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "409fb72b-ca0e-46aa-a7bf-35ca116c0bfc", "AQAAAAEAACcQAAAAELUyFS7aJbhF+intfH6b8GVuxnSY2S3kRwfO3uKo9IjZc+kiYRCRqGpHDrC9JhiUxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e59fcab3-3bb8-42ce-9822-21d2a8c2fd54", "AQAAAAEAACcQAAAAEEHKfVMvz4IlyVoI7mZOwWK0xK0SbSRIqHXncy9a1wNDRGJupAZMWFh0BqJ5xsyLxQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 13, 26, 42, 697, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 13, 26, 42, 697, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 6, 3, 13, 26, 42, 697, DateTimeKind.Utc).AddTicks(5270));
        }
    }
}
