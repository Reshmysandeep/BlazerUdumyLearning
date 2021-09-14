using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class addedbranddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedBy", "CreatedDate", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Toyota", "System", new DateTime(2021, 9, 14, 21, 43, 19, 692, DateTimeKind.Local).AddTicks(5890), "A", "System", new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(3000) },
                    { 2, "BMW", "System", new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4541), "A", "System", new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4549) },
                    { 3, "Nissan", "System", new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4551), "A", "System", new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4552) },
                    { 4, "Honda", "System", new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4554), "A", "System", new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4555) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
