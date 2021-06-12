﻿namespace Microting.EformAngularFrontendBase.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class RenamingSimpleSites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Link",
                value: "/device-users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Link",
                value: "/simplesites");
        }
    }
}
