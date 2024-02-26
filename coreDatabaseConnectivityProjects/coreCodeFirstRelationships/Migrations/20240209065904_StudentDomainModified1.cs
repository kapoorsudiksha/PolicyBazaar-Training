using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreCodeFirstRelationships.Migrations
{
    /// <inheritdoc />
    public partial class StudentDomainModified1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentMaster");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentMaster",
                table: "StudentMaster",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentMaster",
                table: "StudentMaster");

            migrationBuilder.RenameTable(
                name: "StudentMaster",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "StudentId");
        }
    }
}
