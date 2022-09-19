using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "803cf164-f797-407f-87d5-0d3a9fdca9cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4448-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "784c0ffa-825a-444e-977b-dedbc9b7ef74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07caa355-5e9e-4a2d-848a-84185dc82575", "AQAAAAEAACcQAAAAEOolJhcIjGoO+1EldK/OZnnAAcP8D7m1p2HWO07xdh3ixYcZJz7TTAeYn0VPvXHBEQ==", "44088ea9-900e-4325-b5ba-403bfdb57f13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408bb945-3d85-4422-8343-7269fd64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c8cd424-07bd-4d48-a674-8249035850e2", "AQAAAAEAACcQAAAAEMlDptE7Z6VWZpoG5gl1TJfnRaqepheIhz9lz28U7O0DVQC4nOu4uJ856CdbE7xBUw==", "e6c0029d-3284-4370-8d47-d4d90535cd54" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
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
                value: "49311120-bb24-4cb0-8536-1a27b71af63c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4448-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "f0e2ce8d-f35f-40e5-8797-c0cdfb03900d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8822c616-deb6-4e40-95ef-513d020c4f47", "AQAAAAEAACcQAAAAEMJGBRs1Msm7yBAxk3kVjUm1gAHy0OiwCF+KlYduwwGhWWWZGx/XWsV1fhR+Ur+Mlw==", "e3bdc8e4-56ab-4da0-913a-ec6129eaed56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408bb945-3d85-4422-8343-7269fd64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1095ddb-8a42-4fb5-b19d-06747c6fd3b6", "AQAAAAEAACcQAAAAEIq+YuEoQ9g1Sq8YqiBglq8ovLuoSsQLwzIGD7fT1WQ8h5ib4NqbjG/osItFByYN9g==", "70904b89-04b2-4706-8e03-8a2a98bd8cdd" });
        }
    }
}
