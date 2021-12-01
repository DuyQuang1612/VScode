using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Studen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenHocSinh = table.Column<string>(type: "TEXT", nullable: true),
                    NamSinh = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HocLuc = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    XepHang = table.Column<string>(type: "TEXT", nullable: true),
                    Rate = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
