using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SFX.Infrastructure.Migrations
{
    public partial class NullifyColumnscustom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomEntityId",
                table: "CustomFields",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_CustomFields_CustomEntityId",
                table: "CustomFields",
                column: "CustomEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomEntityDefinitions_CustomEntityId",
                table: "CustomFields",
                column: "CustomEntityId",
                principalTable: "CustomEntityDefinitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomEntityDefinitions_CustomEntityId",
                table: "CustomFields");

            migrationBuilder.DropIndex(
                name: "IX_CustomFields_CustomEntityId",
                table: "CustomFields");

            migrationBuilder.DropColumn(
                name: "CustomEntityId",
                table: "CustomFields");

            migrationBuilder.UpdateData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 12, 23, 7, 778, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 12, 23, 7, 778, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 12, 23, 7, 778, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 12, 23, 7, 778, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 13, 23, 7, 777, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 13, 23, 7, 778, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 13, 23, 7, 778, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 18, 12, 23, 7, 778, DateTimeKind.Utc));
        }
    }
}
