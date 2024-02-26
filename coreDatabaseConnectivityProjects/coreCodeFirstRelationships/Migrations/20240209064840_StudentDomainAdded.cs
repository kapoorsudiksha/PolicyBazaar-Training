using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreCodeFirstRelationships.Migrations
{
    /// <inheritdoc />
    public partial class StudentDomainAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9578));
        }
    }
}
