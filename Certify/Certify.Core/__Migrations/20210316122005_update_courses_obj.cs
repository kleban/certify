using Microsoft.EntityFrameworkCore.Migrations;

namespace Certify.Core.Migrations
{
    public partial class update_courses_obj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role_id",
                column: "ConcurrencyStamp",
                value: "554422dd-a517-47c4-8d44-ef45698d2f2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student_role_id",
                column: "ConcurrencyStamp",
                value: "5037f9dc-159d-4731-8c64-4f23b60055a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher_role_id",
                column: "ConcurrencyStamp",
                value: "e42ef533-62b0-4eff-864e-3475902adbe3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4cb1e0-e796-4a5a-9b29-26baecea81ab", "AQAAAAEAACcQAAAAEPWrRWjpdGOL+5EgumWjqPnjEtdqEfp9UeF49y+G3UfkAX6t63YayGv2L+lVFJe5oQ==", "fe67aa1b-ba9d-4a09-9112-0e3a7fc6724e" });
        }
    }
}
