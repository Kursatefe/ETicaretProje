using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderClassinaEklemeYapildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CVV",
                table: "Orders",
                type: "int",
                maxLength: 3,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardNo",
                table: "Orders",
                type: "int",
                maxLength: 16,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 29, 21, 38, 38, 59, DateTimeKind.Local).AddTicks(6762));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CardNo",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 4, 28, 23, 35, 14, 166, DateTimeKind.Local).AddTicks(2199));
        }
    }
}
