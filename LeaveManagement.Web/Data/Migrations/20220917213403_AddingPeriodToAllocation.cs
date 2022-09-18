using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b3a15697-a40b-4fee-a3c6-e5fe1b04cb06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4448-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "5cf68ea8-2626-471b-b886-57158ac1cc39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "026e4e06-4e26-4d0f-9a11-17f3f6b2d1a8", "AQAAAAEAACcQAAAAELISxl0NRGcsjUvdUaAZFUrGiy4QW8jEF6Vcn+v7wyZ+SktibhcU/C8nYOl+EmnkrQ==", "8d6a42e6-ac09-4cdb-9ff5-a129184cc4d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408bb945-3d85-4422-8343-7269fd64d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb5f8cb7-33e7-4897-a14a-a776af8a9fb9", "AQAAAAEAACcQAAAAEFFILQi3wjpCW0UuZQHvkQAcPF545KyX5Aw9+XDRmmHACytwflewOZ+Xy2EYPeYJtg==", "a9dd8c25-1a8d-46c2-a10b-46b38b5c587a" });
        }
    }
}
