using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RateUsers");

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TitleImagePath = table.Column<string>(nullable: true),
                    Metatitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeyWords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    AvgRateActor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmsAndActors",
                columns: table => new
                {
                    IdNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFilm = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    IdActor = table.Column<Guid>(nullable: false),
                    NameActor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmsAndActors", x => x.IdNumber);
                    table.ForeignKey(
                        name: "FK_FilmsAndActors_Actors_IdActor",
                        column: x => x.IdActor,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmsAndActors_ServiceItems_IdFilm",
                        column: x => x.IdFilm,
                        principalTable: "ServiceItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FilmsAndActors_IdActor",
                table: "FilmsAndActors",
                column: "IdActor");

            migrationBuilder.CreateIndex(
                name: "IX_FilmsAndActors_IdFilm",
                table: "FilmsAndActors",
                column: "IdFilm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmsAndActors");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.CreateTable(
                name: "RateUsers",
                columns: table => new
                {
                    IdNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFilm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RateFilm = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateUsers", x => x.IdNumber);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "89f8260a-013b-44e5-a88c-b17795a4fa5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f",
                column: "ConcurrencyStamp",
                value: "9d2d8732-38c2-4a42-90f3-5ed85f977ed9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3daf19cf-8492-481a-bf06-1005d0f29046", "AQAAAAEAACcQAAAAECHxwRUehzA+HzLvZdebQJ38eW73RYhHFtpe83k5bz/pNH7Ce5NI6d+XaRy31u9YIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c000e066-76de-4925-8cea-c641b289b06c", "AQAAAAEAACcQAAAAEKyWLH28/i3K58LjON7NelVvUhfRlDI3hjYbOuwQxqYtPBCTSWCDGkO5e2+JgUmcaQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 14, 13, 2, 57, 88, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 14, 13, 2, 57, 88, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 5, 14, 13, 2, 57, 88, DateTimeKind.Utc).AddTicks(5422));
        }
    }
}
