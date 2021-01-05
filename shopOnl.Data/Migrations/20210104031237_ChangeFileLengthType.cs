using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shopOnl.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0c97e5e-f91e-432b-8819-a4c2d3fd2926"),
                column: "ConcurrencyStamp",
                value: "bdb364b1-4692-434d-b84e-4a511471994b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fc4a6d8-26b9-4eb9-bdc4-e8f0af4595ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7184c16d-95fb-4973-9312-1f7241651795", "AQAAAAEAACcQAAAAEBUQFWtFfbO4+fkc2u7BL9tLnpM9HZXDNlJ1igwWX2/t4FldEYBJ8d7iawHEr4+sjQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 1, 4, 10, 12, 36, 404, DateTimeKind.Local).AddTicks(1830));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f0c97e5e-f91e-432b-8819-a4c2d3fd2926"),
                column: "ConcurrencyStamp",
                value: "1c6e3b45-3398-4f66-9e97-ad0db5b1d27c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2fc4a6d8-26b9-4eb9-bdc4-e8f0af4595ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da19badb-02ab-4dcb-b9aa-7369084748ff", "AQAAAAEAACcQAAAAEFtSptej+nvBVE1HwIMNsElSKg4mwuSC4g7yKyTBg61UR70bnDM1An7QvqlNv6gXZA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 12, 29, 14, 32, 31, 312, DateTimeKind.Local).AddTicks(8283));
        }
    }
}
