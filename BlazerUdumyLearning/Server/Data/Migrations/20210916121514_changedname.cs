using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class changedname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "bf9c8a8f-66ae-4c75-b3c0-4c5b288cf345");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4e84ec8c-c049-4ba8-a163-844c0e27aeac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24e0b7c1-7b31-4263-ab2a-277a1bb7e91a", "AQAAAAEAACcQAAAAEL8NQTwVHYvS7s6dmnXu8JclY070TD4QxKfsqSluzKInRk40FWKGqQyS5huGv3+m6A==", "066e5998-5f07-4856-b928-62d342de5aca" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8450), new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8750), new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8754), new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8756), new DateTime(2021, 9, 16, 16, 15, 14, 426, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2447), new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2753), new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2758), new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2760), new DateTime(2021, 9, 16, 16, 15, 14, 427, DateTimeKind.Local).AddTicks(2761) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b90a20aa-9383-4f7d-a2a4-bf9862e6046d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "297e18d0-5c5e-4d3b-b4df-73bd82b91e1f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce5f90cf-a8ca-4890-a08d-846341a78a49", "AQAAAAEAACcQAAAAENz/Ka63Kcwym6Uzt67HshbwMzNosVHVv4/brhOJPf0ShaXmxqoDVBg+EexlOfcQGQ==", "421b4b7a-6d3c-4ba7-b3cb-b81317ddc0a2" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(5867), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(6206), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(6212), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(6214), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9449), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9950), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9956), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9959), new DateTime(2021, 9, 16, 13, 22, 57, 674, DateTimeKind.Local).AddTicks(9960) });
        }
    }
}
