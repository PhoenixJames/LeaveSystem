using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddLeaveTypesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "leavetypes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "leavetypes",
                columns: new[] { "id", "createddate", "Type", "updateddate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 2, 3, 15, 24, 52, 465, DateTimeKind.Utc).AddTicks(3812), "Casual Leave", new DateTime(2023, 2, 3, 15, 24, 52, 465, DateTimeKind.Utc).AddTicks(3813) },
                    { 2L, new DateTime(2023, 2, 3, 15, 24, 52, 465, DateTimeKind.Utc).AddTicks(3815), "Medical Leave", new DateTime(2023, 2, 3, 15, 24, 52, 465, DateTimeKind.Utc).AddTicks(3815) },
                    { 3L, new DateTime(2023, 2, 3, 15, 24, 52, 465, DateTimeKind.Utc).AddTicks(3817), "Earned Leave", new DateTime(2023, 2, 3, 15, 24, 52, 465, DateTimeKind.Utc).AddTicks(3817) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "leavetypes",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "leavetypes",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "leavetypes",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.AlterColumn<long>(
                name: "Type",
                table: "leavetypes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
