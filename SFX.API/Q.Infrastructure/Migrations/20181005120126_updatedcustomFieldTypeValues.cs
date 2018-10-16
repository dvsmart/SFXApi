using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SFX.Infrastructure.Migrations
{
    public partial class updatedcustomFieldTypeValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 1, 26, 227, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Caption",
                value: "Text Box");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Caption",
                value: "Calender");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Caption",
                value: "Time");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Caption",
                value: "Text Area");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Caption",
                value: "Currency Input");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Caption",
                value: "Checkbox");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Caption",
                value: "Select / List");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Caption",
                value: "Numerical Input");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Caption",
                value: "Percentage Input");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Caption",
                value: "Image Upload");

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Caption", "Type" },
                values: new object[] { "EmailAddress Input", "email" });

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Caption", "Type" },
                values: new object[] { "RichTextBox", "richtextarea" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 11, 48, 29, 640, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Caption", "Type" },
                values: new object[] { null, "phone" });

            migrationBuilder.UpdateData(
                table: "CustomFieldTypes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Caption", "Type" },
                values: new object[] { null, "email" });

            migrationBuilder.InsertData(
                table: "CustomFieldTypes",
                columns: new[] { "Id", "Caption", "Type" },
                values: new object[] { 13, null, "richtextarea" });

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 11, 48, 29, 640, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 11, 48, 29, 640, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "MenuGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 11, 48, 29, 640, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 48, 29, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 48, 29, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "RecurrenceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 12, 48, 29, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2018, 10, 5, 11, 48, 29, 640, DateTimeKind.Utc));
        }
    }
}
