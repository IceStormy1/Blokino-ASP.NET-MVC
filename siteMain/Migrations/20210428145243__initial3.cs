using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace siteMain.Migrations
{
    public partial class _initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllFilms",
                columns: table => new
                {
                    IdFilm = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    AvgRateFilm = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllFilms", x => x.IdFilm);
                });

            migrationBuilder.CreateTable(
                name: "UserRate",
                columns: table => new
                {
                    RateFilm = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    IdFilm = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRate", x => x.RateFilm);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "324cb551-dcab-45f6-b8c2-52805ceabf27");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf0dc572-32bd-4119-a388-4934f630896f", "2058662d-615f-4371-8573-de68e8922a41", "DefaultUser", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83f097b5-217f-425e-996c-ed61909d0b4e", "AQAAAAEAACcQAAAAELUQFrAitJ5yBweflL4T9A88xwsiroVd26WKgVFqyKWREG3CLMLzRD3lxDwHo+AlbQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2803a9ed-8c75-4696-a109-1848a86d40ec", 0, "9b9a6ee0-5025-4892-bc95-95ad61d3108e", "mishytka-02@mail.com", true, false, null, "MISHYTKA-02@MAIL.RU", "MISHA", "AQAAAAEAACcQAAAAELgQ0+9R+CM/UD2K3zHeUChI4DSnuJoqfhEPEKkuGdePdi1sj76tw2qxzV0ShTWpoA==", null, false, "", false, "Misha" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 14, 52, 43, 314, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 14, 52, 43, 314, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 28, 14, 52, 43, 314, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2803a9ed-8c75-4696-a109-1848a86d40ec", "cf0dc572-32bd-4119-a388-4934f630896f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllFilms");

            migrationBuilder.DropTable(
                name: "UserRate");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2803a9ed-8c75-4696-a109-1848a86d40ec", "cf0dc572-32bd-4119-a388-4934f630896f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf0dc572-32bd-4119-a388-4934f630896f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2803a9ed-8c75-4696-a109-1848a86d40ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "9a0cabe7-ae92-49ca-81a1-ca9467c678a4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f188b215-4dd4-450e-ab6f-3fc98f80d99f", "AQAAAAEAACcQAAAAELY7iFpRbLQDIw46Qnb75lA399S11QUel1ndI0+9V+sBL1v4Q7w70/apWr9m6Wd3Bg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 6, 12, 31, 26, 820, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 6, 12, 31, 26, 819, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2021, 4, 6, 12, 31, 26, 820, DateTimeKind.Utc).AddTicks(103));
        }
    }
}
