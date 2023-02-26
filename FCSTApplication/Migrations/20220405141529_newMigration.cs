using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FCSTApplication.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WheatPrice",
                table: "StarchData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ThaiPrice",
                table: "StarchData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CornPrice",
                table: "StarchData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ChinaShandongPrice",
                table: "StarchData",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CoalData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Week = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    CoalPrice_5800 = table.Column<int>(nullable: true),
                    CoalPrice_5500 = table.Column<int>(nullable: true),
                    CoalPrice_5000 = table.Column<int>(nullable: true),
                    SpotPrice_5500 = table.Column<int>(nullable: true),
                    BohaiInventory = table.Column<int>(nullable: true),
                    PortChinInventory = table.Column<int>(nullable: true),
                    DeliveryFee = table.Column<int>(nullable: true),
                    NewcPrice = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoalData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoalData");

            migrationBuilder.AlterColumn<int>(
                name: "WheatPrice",
                table: "StarchData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ThaiPrice",
                table: "StarchData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CornPrice",
                table: "StarchData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ChinaShandongPrice",
                table: "StarchData",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
