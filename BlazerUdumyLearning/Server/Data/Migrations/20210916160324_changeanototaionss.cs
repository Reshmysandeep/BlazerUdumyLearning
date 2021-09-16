using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class changeanototaionss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
