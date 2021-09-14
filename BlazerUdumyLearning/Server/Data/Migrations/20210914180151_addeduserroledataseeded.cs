using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazerUdumyLearning.Server.Data.Migrations
{
    public partial class addeduserroledataseeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "6263ec74-7abd-40c3-8b5a-9ae35a68f98a", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "e84e8256-c294-4a51-b31e-e206a3c0455f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "4a29e15c-dc41-4a8e-a709-ead26b95c951", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAELDRJPpNfcbDkQdB/l4O0FYW6gX/LW/HVS9d2j9H5kk6GFb80tCqs+1FJn9W8BevAA==", null, false, "bca63174-fd72-4e70-9c91-e50cf7e816b4", false, "Admin" });

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
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(91), "A", new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(416), "A", new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(421), "A", new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(424), "A", new DateTime(2021, 9, 14, 22, 1, 51, 352, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(402), null, new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(689), null, new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(693), null, new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(696), null, new DateTime(2021, 9, 14, 21, 45, 12, 811, DateTimeKind.Local).AddTicks(696) });
        }
    }
}
