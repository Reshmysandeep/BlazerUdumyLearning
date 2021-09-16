using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class changeanototaions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3455a932-df3d-4209-8646-91eb709b2de5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "5104a06d-cbc7-4b28-a077-b3009409daa7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77ed2de3-611d-4af9-847e-582d4709a737", "AQAAAAEAACcQAAAAEEP3yTqgI5X1vv0kU6kkQ484BUdXiEDvRVPqAOSq0tvS/M5mJwbJFSBHSuoUg1tjKw==", "49f664f9-a6a1-4e69-a7e1-2f1d03f43b69" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8068), new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8383), new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8388), new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8390), new DateTime(2021, 9, 16, 20, 0, 46, 366, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(1766), new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(2065), new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(2070), new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(2072), new DateTime(2021, 9, 16, 20, 0, 46, 367, DateTimeKind.Local).AddTicks(2073) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
