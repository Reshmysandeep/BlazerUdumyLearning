using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class changeanototaion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "e0f148b4-b46d-4eaf-a5e6-57177a66bdef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "43dc8baf-34e6-4211-acf1-f23688ccd698");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20148cba-fb08-4a29-b905-4148c0e0cad7", "AQAAAAEAACcQAAAAEMwoCW38/exXT0Mr7PyiggqlNRz0rhXWBPu/zDcDha5sr+mZFsY6qg+eSaaoBzaZ5A==", "9ab34e33-3bc1-4ac5-a35b-561bb77ec75c" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(8991), new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(9316), new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(9320), new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(9323), new DateTime(2021, 9, 16, 19, 59, 35, 988, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2154), new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2444), new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2448), new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2451), new DateTime(2021, 9, 16, 19, 59, 35, 989, DateTimeKind.Local).AddTicks(2451) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "10f75703-e4bf-47ff-8435-7f603e391a52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "ed0468bd-a98c-4e3d-8e6f-587c52dfa1cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33675e7-184d-43cb-af0c-97f8bcebc2dd", "AQAAAAEAACcQAAAAELvlflbKRf3/xa1tFuCouKCfX8MA/NzLF84lO7UDuRRYokQD5W/a/MxRKfJB//jFQA==", "610ade0f-f1e7-4443-b366-8be1db028dcd" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8068), new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8363), new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8368), new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8370), new DateTime(2021, 9, 16, 19, 56, 47, 512, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1260), new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1543), new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1547), new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1549), new DateTime(2021, 9, 16, 19, 56, 47, 513, DateTimeKind.Local).AddTicks(1550) });
        }
    }
}
