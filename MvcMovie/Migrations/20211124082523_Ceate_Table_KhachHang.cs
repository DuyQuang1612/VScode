using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class Ceate_Table_KhachHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    KhachHangID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenKhachHang = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.KhachHangID);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    HoaDonID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KhachHangID = table.Column<int>(type: "INTEGER", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.HoaDonID);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "KhachHangID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangID",
                table: "HoaDons",
                column: "KhachHangID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
