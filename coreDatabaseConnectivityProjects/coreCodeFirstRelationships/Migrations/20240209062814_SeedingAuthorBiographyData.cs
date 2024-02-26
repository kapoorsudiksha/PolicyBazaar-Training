using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace coreCodeFirstRelationships.Migrations
{
    /// <inheritdoc />
    public partial class SeedingAuthorBiographyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "authorBiographies",
                columns: new[] { "AuthorBiographyId", "AuthorId", "Biography", "DateOfBirth", "PlaceOfBirth" },
                values: new object[,]
                {
                    { 1, 1, "Some Details Here", new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9562), "Delhi" },
                    { 2, 2, "Some Details Here", new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9574), "Mumbai" },
                    { 3, 3, "Some Details Here", new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9576), "Chennai" },
                    { 4, 4, "Some Details Here", new DateTime(2024, 2, 9, 11, 58, 13, 719, DateTimeKind.Local).AddTicks(9578), "Hyderabad" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "authorBiographies",
                keyColumn: "AuthorBiographyId",
                keyValue: 4);
        }
    }
}
