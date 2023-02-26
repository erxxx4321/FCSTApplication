using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FCSTApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StarchData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Week = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ChinaShandongPrice = table.Column<int>(nullable: false),
                    ThaiPrice = table.Column<int>(nullable: false),
                    CornPrice = table.Column<int>(nullable: false),
                    WheatPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarchData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StarchData");
        }
    }
}
