using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ank9ServerApiModel.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tc = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dogumtarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kisiler_Tc",
                table: "Kisiler",
                column: "Tc",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
