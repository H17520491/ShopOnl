using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopOnl.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("f0c97e5e-f91e-432b-8819-a4c2d3fd2926"), "1c6e3b45-3398-4f66-9e97-ad0db5b1d27c", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("2fc4a6d8-26b9-4eb9-bdc4-e8f0af4595ff"), new Guid("f0c97e5e-f91e-432b-8819-a4c2d3fd2926") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2fc4a6d8-26b9-4eb9-bdc4-e8f0af4595ff"), 0, "da19badb-02ab-4dcb-b9aa-7369084748ff", new DateTime(2020, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "truchoale29@gmail.com", true, "Hoa", "le", false, null, "truchoale29@gmail.com", "admin", "AQAAAAEAACcQAAAAEFtSptej+nvBVE1HwIMNsElSKg4mwuSC4g7yKyTBg61UR70bnDM1An7QvqlNv6gXZA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 29, 14, 32, 31, 312, DateTimeKind.Local).AddTicks(8283));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0c97e5e-f91e-432b-8819-a4c2d3fd2926"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("2fc4a6d8-26b9-4eb9-bdc4-e8f0af4595ff"), new Guid("f0c97e5e-f91e-432b-8819-a4c2d3fd2926") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fc4a6d8-26b9-4eb9-bdc4-e8f0af4595ff"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 24, 15, 50, 45, 95, DateTimeKind.Local).AddTicks(3090));
        }
    }
}
