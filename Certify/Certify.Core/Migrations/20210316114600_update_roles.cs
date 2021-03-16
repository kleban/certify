using Microsoft.EntityFrameworkCore.Migrations;

namespace Certify.Core.Migrations
{
    public partial class update_roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "teacher_role_id", "admin_user_id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4cb1e0-e796-4a5a-9b29-26baecea81ab", "AQAAAAEAACcQAAAAEPWrRWjpdGOL+5EgumWjqPnjEtdqEfp9UeF49y+G3UfkAX6t63YayGv2L+lVFJe5oQ==", "fe67aa1b-ba9d-4a09-9112-0e3a7fc6724e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "teacher_role_id", "admin_user_id" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role_id",
                column: "ConcurrencyStamp",
                value: "f2e9c6e0-c854-4cd7-a47d-dd7777c2403b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student_role_id",
                column: "ConcurrencyStamp",
                value: "ffabecc5-b043-48d8-9ae4-72ba08d8f417");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher_role_id",
                column: "ConcurrencyStamp",
                value: "a2950bbb-df43-4ad3-825e-e502f2ead87d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1067c6f4-67e5-41ca-a467-d33a94c882e3", "AQAAAAEAACcQAAAAEE+BoDuy7ccDx92e0k6EkgZSIFKWDJ0v2b/fWtwIhBZi2mWY2zhK5NjEO6hQ82GdHg==", "9d53e0f9-a37a-468e-ad8a-cb302e086f62" });
        }
    }
}
