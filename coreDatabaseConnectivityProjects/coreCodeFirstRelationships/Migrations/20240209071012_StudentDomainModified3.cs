using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreCodeFirstRelationships.Migrations
{
    /// <inheritdoc />
    public partial class StudentDomainModified3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StudentMaster",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "StudentMaster",
                newName: "StudentDetailId");

            migrationBuilder.AlterColumn<double>(
                name: "Age",
                table: "StudentMaster",
                type: "float",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "StudentMaster",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "StudentDetailId",
                table: "StudentMaster",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                table: "StudentMaster",
                type: "DateTime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoB",
                table: "StudentMaster");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "StudentMaster",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "StudentDetailId",
                table: "StudentMaster",
                newName: "StudentId");

            migrationBuilder.AlterColumn<double>(
                name: "Age",
                table: "StudentMaster",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 40)
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "StudentMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentMaster",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 0)
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
