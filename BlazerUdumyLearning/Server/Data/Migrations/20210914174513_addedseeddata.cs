using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class addedseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7361), new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7668), new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7703), new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7706), new DateTime(2021, 9, 14, 21, 45, 12, 810, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModelName", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(402), "Prius", null, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(407) },
                    { 2, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(689), "Vitz", null, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(692) },
                    { 3, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(693), "3 Series", null, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(694) },
                    { 4, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(696), "X5", null, "System", new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(696) }
                });

            migrationBuilder.InsertData(
                table: "VehicleColors",
                columns: new[] { "Id", "Color", "CreatedBy", "CreatedDate", "Status", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Black", "system", new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "A", "System", new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, "Green", "system", new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "A", "System", new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, "Red", "system", new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "A", "System", new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 43, 19, 692, DateTimeKind.Local).AddTicks(5890), new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4541), new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4551), new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4554), new DateTime(2021, 9, 14, 21, 43, 19, 694, DateTimeKind.Local).AddTicks(4555) });
        }
    }
}
