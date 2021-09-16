using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class anotationchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
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
                value: "9de9b7e1-37f9-4a89-866f-90111296094f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "2aaa1e19-6fd2-40b1-bc8c-daece8b5f7b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ce6db0-1879-4dbe-8ea3-7c0db0fdf444", "AQAAAAEAACcQAAAAEBXHf5nMQCz4y9+PtFfEEhtEcitcr41OCQ+3HT77Kq73bTBqeTYs4F1s0kPEa+8Avg==", "2cbb5547-93b4-4a79-9d75-3eda1d3f168e" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6007), new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6342), new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6347), new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6350), new DateTime(2021, 9, 16, 20, 5, 20, 433, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(211), new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(610), new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(664), new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(668), new DateTime(2021, 9, 16, 20, 5, 20, 434, DateTimeKind.Local).AddTicks(668) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

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
                value: "3ba3f0b2-edfa-4832-904a-48bdc6118c48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "2c78e9e3-9a9d-4b9a-bbc2-b2df621d285b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be9ff23b-d9f8-4bcb-ab8b-f389269601f9", "AQAAAAEAACcQAAAAEJRd5/IdXQDRGaZPfOKWTFeSQPdypa0bE4ZO/tahbPVih4UL1x4JccK0OGpmT+/4Ag==", "2afba0b5-3db9-4f89-8f63-3cdee345f9c2" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4285), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4594), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4598), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4600), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7425), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7709), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7713), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7715), new DateTime(2021, 9, 16, 20, 3, 24, 1, DateTimeKind.Local).AddTicks(7716) });
        }
    }
}
