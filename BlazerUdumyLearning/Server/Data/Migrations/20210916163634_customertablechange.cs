using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class customertablechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Customers",
                newName: "Email");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "728353e8-65c0-477d-8c18-bc99b5d4bd92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "42f519dc-927b-4c20-98ca-c53a191bdc43");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0cbbd01-1073-4c1a-8b90-4b0f7f3137a5", "AQAAAAEAACcQAAAAENqu2URTSUh7IdEMQsEVRAVatyy06Htv30aJDQRO32+v1Qg+03QIJTH686cPuSJAiQ==", "d59b1b12-c5fc-4b78-b6a5-c66db553d404" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1563), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1881), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1886), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1889), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(4896), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(5193), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(5198), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(5201), new DateTime(2021, 9, 16, 20, 36, 34, 246, DateTimeKind.Local).AddTicks(5201) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "EmailAddress");

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
    }
}
