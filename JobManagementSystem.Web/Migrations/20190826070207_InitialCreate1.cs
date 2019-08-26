using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobManagementSystem.Web.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BrithDay",
                table: "Users",
                newName: "BirthDay");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2019, 8, 26, 14, 2, 6, 907, DateTimeKind.Local).AddTicks(9592));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Users",
                newName: "BrithDay");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2019, 8, 26, 1, 2, 35, 897, DateTimeKind.Local).AddTicks(617));
        }
    }
}
