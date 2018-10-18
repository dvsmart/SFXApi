using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SFX.Infrastructure.Migrations
{
    public partial class NullifyColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomEntityDefinitions_CustomEntityGroups_EntityGroupId",
                table: "CustomEntityDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomTabs_CustomTabId",
                table: "CustomFields");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "UserProfile");

            migrationBuilder.AlterColumn<int>(
                name: "CustomTabId",
                table: "CustomFields",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EntityGroupId",
                table: "CustomEntityDefinitions",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.CreateIndex(
                name: "IX_CustomFieldValues_CustomFieldId",
                table: "CustomFieldValues",
                column: "CustomFieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomEntityDefinitions_CustomEntityGroups_EntityGroupId",
                table: "CustomEntityDefinitions",
                column: "EntityGroupId",
                principalTable: "CustomEntityGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomTabs_CustomTabId",
                table: "CustomFields",
                column: "CustomTabId",
                principalTable: "CustomTabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFieldValues_CustomFields_CustomFieldId",
                table: "CustomFieldValues",
                column: "CustomFieldId",
                principalTable: "CustomFields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomEntityDefinitions_CustomEntityGroups_EntityGroupId",
                table: "CustomEntityDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFields_CustomTabs_CustomTabId",
                table: "CustomFields");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomFieldValues_CustomFields_CustomFieldId",
                table: "CustomFieldValues");

            migrationBuilder.DropIndex(
                name: "IX_CustomFieldValues_CustomFieldId",
                table: "CustomFieldValues");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "UserProfile",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomTabId",
                table: "CustomFields",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EntityGroupId",
                table: "CustomEntityDefinitions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 1, 26, 227, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 1, 26, 228, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 1, 26, 228, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 1, 26, 228, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 13, 1, 26, 227, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 13, 1, 26, 227, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 13, 1, 26, 227, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 1, 26, 228, DateTimeKind.Utc));

            migrationBuilder.AddForeignKey(
                name: "FK_CustomEntityDefinitions_CustomEntityGroups_EntityGroupId",
                table: "CustomEntityDefinitions",
                column: "EntityGroupId",
                principalTable: "CustomEntityGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomFields_CustomTabs_CustomTabId",
                table: "CustomFields",
                column: "CustomTabId",
                principalTable: "CustomTabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
