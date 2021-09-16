using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class colchnage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandsId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BrandsId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "BrandsId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "MakeId",
                table: "Vehicles",
                newName: "BrandId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BrandId",
                table: "Vehicles",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandId",
                table: "Vehicles",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_BrandId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Vehicles",
                newName: "MakeId");

            migrationBuilder.AddColumn<int>(
                name: "BrandsId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "02ac9458-3e4a-4bc1-9f91-2f32f26e7308");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "96538a9d-e3ec-4c47-b733-b747bfe8e319");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67bd6515-9097-4453-95ff-c0a3920a6674", "AQAAAAEAACcQAAAAEPeKCLJXq3PZlMua/vYsvu22G3QXD2ESDLxCAK7tetKjGbjvVr5nHT9hKE8Oj9Ogxg==", "7f141b33-12c3-4336-946c-867ae37d73a6" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(7967), new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(8350), new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(8355), new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(8358), new DateTime(2021, 9, 16, 13, 19, 20, 318, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1594), new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1950), new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1956), new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1959), new DateTime(2021, 9, 16, 13, 19, 20, 319, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BrandsId",
                table: "Vehicles",
                column: "BrandsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandsId",
                table: "Vehicles",
                column: "BrandsId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
