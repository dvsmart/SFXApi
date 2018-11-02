using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SFX.Infrastructure.Migrations
{
    public partial class TabTableChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOptional",
                table: "CustomTabs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 53, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 53, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 53, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 53, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 52, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 53, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 53, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 11, 1, 9, 52, 22, 53, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOptional",
                table: "CustomTabs");

            migrationBuilder.UpdateData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 14, 20, 26, 64, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 15, 20, 26, 64, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 15, 20, 26, 64, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 15, 20, 26, 64, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 14, 20, 26, 65, DateTimeKind.Utc));
        }
    }
}
