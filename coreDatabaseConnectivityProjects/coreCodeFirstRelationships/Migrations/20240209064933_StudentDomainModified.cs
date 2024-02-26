using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreCodeFirstRelationships.Migrations
{
    /// <inheritdoc />
    public partial class StudentDomainModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Age",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 19, 32, 711, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 19, 32, 711, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 19, 32, 711, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 19, 32, 711, DateTimeKind.Local).AddTicks(581));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 12, 18, 39, 697, DateTimeKind.Local).AddTicks(4009));
        }
    }
}
