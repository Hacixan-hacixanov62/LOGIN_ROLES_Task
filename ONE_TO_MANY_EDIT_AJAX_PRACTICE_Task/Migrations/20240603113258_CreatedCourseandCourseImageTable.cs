using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Migrations
{
    public partial class CreatedCourseandCourseImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CourseImages");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CourseImages");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CourseImages");

            migrationBuilder.RenameColumn(
                name: "SoftDeleted",
                table: "CourseImages",
                newName: "IsMain");

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Courses",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "IsMain",
                table: "CourseImages",
                newName: "SoftDeleted");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseImages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CourseImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "CourseImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CourseImages",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
