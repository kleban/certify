using Microsoft.EntityFrameworkCore.Migrations;

namespace Certify.Core.Migrations
{
    public partial class db_gen_certificate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role_id",
                column: "ConcurrencyStamp",
                value: "12a3d3c7-df02-4a74-bd0a-bd4a6848fc20");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student_role_id",
                column: "ConcurrencyStamp",
                value: "519cd7b4-91e2-44d9-8e19-3d05c33c1d67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher_role_id",
                column: "ConcurrencyStamp",
                value: "b3580ee8-6b8f-4d45-a1d1-ebabbe06c8f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb30a524-1b65-40bd-8946-2ff1e3df39d4", "AQAAAAEAACcQAAAAEMknxzUCvdQnfofQdvDtQIyb+VkHgpR4khHKEzd/9/4nq38xsdDYn490DWv5LZSQ+A==", "b8bd3db5-b52c-40c2-8bca-03cc55c0bd17" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role_id",
                column: "ConcurrencyStamp",
                value: "4120646d-a5ef-4524-9d85-d8476be7d1e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student_role_id",
                column: "ConcurrencyStamp",
                value: "88becb9d-8d98-4a8a-889a-1f2119e628e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher_role_id",
                column: "ConcurrencyStamp",
                value: "53238598-b6b2-415a-9e64-68878d62c14b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de111363-fec6-4e9e-9d9a-56d3d44e6d6e", "AQAAAAEAACcQAAAAEGsCct1XCs5botPG+ENbMzM2dFJtbEt+Dxzq8p6VZ9ebGfDWabu0ITvp6Gteo7ktdA==", "e9f21d22-6a3d-4493-aa2c-ea5349fa11a9" });
        }
    }
}
