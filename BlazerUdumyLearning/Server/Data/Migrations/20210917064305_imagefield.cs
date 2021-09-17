using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class imagefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f47afa47-eb98-428d-b0c7-de797662ee47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e7d35b51-4c91-4bd7-af85-dba50732b343");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3920da4-073e-4a0b-9fca-75d027f11c8b", "AQAAAAEAACcQAAAAEEXVeVwumddaE00Dfyv6gqq9wXX5zO5xH+E48XDtThjjFchl9/gMV3Pyk+27X8++mg==", "ac1f32cd-065b-4820-a811-3973a746e234" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8021), new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8337), new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8342), new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8345), new DateTime(2021, 9, 17, 10, 43, 4, 885, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1422), new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1731), new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1736), new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1739), new DateTime(2021, 9, 17, 10, 43, 4, 886, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageName",
                table: "Vehicles");

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

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
