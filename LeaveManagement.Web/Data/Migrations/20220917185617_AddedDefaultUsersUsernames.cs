using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "026e4e06-4e26-4d0f-9a11-17f3f6b2d1a8", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAELISxl0NRGcsjUvdUaAZFUrGiy4QW8jEF6Vcn+v7wyZ+SktibhcU/C8nYOl+EmnkrQ==", "8d6a42e6-ac09-4cdb-9ff5-a129184cc4d5", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408bb945-3d85-4422-8343-7269fd64d940",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cb5f8cb7-33e7-4897-a14a-a776af8a9fb9", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFFILQi3wjpCW0UuZQHvkQAcPF545KyX5Aw9+XDRmmHACytwflewOZ+Xy2EYPeYJtg==", "a9dd8c25-1a8d-46c2-a10b-46b38b5c587a", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "04f7056b-f7ef-4425-a385-982a478d44f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4448-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "88828a11-0aa0-4793-840d-3e89ee25271f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "71287eec-2593-46a8-9422-2cef193c10ca", false, null, "AQAAAAEAACcQAAAAEP4Yw08ja84xQe4RTmsb1KcTIgtRcOysmeserM6/sGc2BZyyaCx1x6Gs3bkrsSgnzw==", "ad75ed3d-557e-4b0d-a76d-86ab110175a5", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408bb945-3d85-4422-8343-7269fd64d940",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "855c9b61-e0fd-41d7-a47f-02185c318485", false, null, "AQAAAAEAACcQAAAAELkcDFM0ZZNL1hYBFE64PceebaV4GdW1dCkFjjgLivgzBzYTlkCvfEgU3E8rL14xqg==", "f8a85157-c7a9-4aa8-92cb-87002abf584f", null });
        }
    }
}
