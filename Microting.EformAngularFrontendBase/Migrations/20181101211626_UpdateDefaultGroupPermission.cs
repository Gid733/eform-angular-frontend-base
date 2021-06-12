﻿/*
The MIT License (MIT)

Copyright (c) 2007 - 2021 Microting A/S

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace Microting.EformAngularFrontendBase.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class UpdateDefaultGroupPermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 38, 1 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 39, 1 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 41, 1 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 40, 1 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "PermissionId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "PermissionId",
                value: 42);

            migrationBuilder.InsertData(
                table: "GroupPermissions",
                columns: new[] { "Id", "PermissionId", "SecurityGroupId" },
                values: new object[,]
                {
                    { 19, 34, 2 },
                    { 20, 33, 2 },
                    { 21, 35, 2 },
                    { 22, 37, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 29, 2 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 42, 2 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 34, 2 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PermissionId", "SecurityGroupId" },
                values: new object[] { 33, 2 });

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "PermissionId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "GroupPermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "PermissionId",
                value: 37);
        }
    }
}
