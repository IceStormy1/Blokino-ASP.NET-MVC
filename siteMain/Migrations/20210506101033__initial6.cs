using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRate_AllFilms_AllFilmsIdFilm",
                table: "UserRate");

            migrationBuilder.DropTable(
                name: "AllFilms");

            migrationBuilder.DropIndex(
                name: "IX_UserRate_AllFilmsIdFilm",
                table: "UserRate");

            migrationBuilder.DropColumn(
                name: "AllFilmsIdFilm",
                table: "UserRate");

            migrationBuilder.AddColumn<float>(
                name: "AvgRateFilm",
                table: "ServiceItems",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "88d9cb7d-630b-4950-9a32-00cd18a83b1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "cf870e03-704d-4034-9a8c-843bd102a0d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff087cda-47a4-4bb9-87b3-e2dc8c334743", "AQAAAAEAACcQAAAAEAl6tCH0sDla0T7AZHVx/lp+OA5gUs76gce5kLo0GhHEUORrSFSBfGlxuPoKaGC9lA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a184ccbf-cfa4-438a-a273-bc36df6e20a4", "AQAAAAEAACcQAAAAENNu6DLlQxnv7wWVKWLV10B9nzAzl5k5wnwkNxQGE7NK8+Nm2PeBCzft64Bm1xcutg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 6, 10, 10, 33, 239, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 6, 10, 10, 33, 239, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 6, 10, 10, 33, 239, DateTimeKind.Utc).AddTicks(6852));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvgRateFilm",
                table: "ServiceItems");

            migrationBuilder.AddColumn<Guid>(
                name: "AllFilmsIdFilm",
                table: "UserRate",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AllFilms",
                columns: table => new
                {
                    IdFilm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvgRateFilm = table.Column<float>(type: "real", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllFilms", x => x.IdFilm);
                });

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
    }
}
