using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class codechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Vehicles",
                newName: "BrandsId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_BrandId",
                table: "Vehicles",
                newName: "IX_Vehicles_BrandsId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandsId",
                table: "Vehicles",
                column: "BrandsId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandsId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "BrandsId",
                table: "Vehicles",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_BrandsId",
                table: "Vehicles",
                newName: "IX_Vehicles_BrandId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6263ec74-7abd-40c3-8b5a-9ae35a68f98a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "e84e8256-c294-4a51-b31e-e206a3c0455f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a29e15c-dc41-4a8e-a709-ead26b95c951", "AQAAAAEAACcQAAAAELDRJPpNfcbDkQdB/l4O0FYW6gX/LW/HVS9d2j9H5kk6GFb80tCqs+1FJn9W8BevAA==", "bca63174-fd72-4e70-9c91-e50cf7e816b4" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(6919), new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(7226), new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(7231), new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(7233), new DateTime(2021, 9, 14, 22, 1, 51, 351, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(91), new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(416), new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(421), new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(424), new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "VehicleColors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandId",
                table: "Vehicles",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
