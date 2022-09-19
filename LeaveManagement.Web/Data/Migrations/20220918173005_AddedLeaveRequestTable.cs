using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "5fd7e43e-39e1-4ef8-b78a-1e301392fd8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4448-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "29fed2d0-9063-4b61-9f09-e377ba532469");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9069aadc-0c52-43c9-aa0e-edcb0be8aeb3", "AQAAAAEAACcQAAAAEP1lcBYVMkoNLrSzE3FDouvBaVhTscib40+2Y9tMqq1RQbKs0gO0CQS4fxXHL8Htcg==", "71332386-ad78-453c-a7ca-553e98f02c00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408bb945-3d85-4422-8343-7269fd64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5e45684-6fc1-4d7c-8481-82e9951d96f9", "AQAAAAEAACcQAAAAEEttHcsZsjlUKPModYuepdJKzfqQnq4O5buT0qGs1DUAtcUQIRYega63lR57Wgiibw==", "401217bd-34fd-46d6-a5fe-31c481e7787e" });
        }
    }
}
