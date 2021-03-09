using Microsoft.EntityFrameworkCore.Migrations;

namespace Certify.Core.Migrations
{
    public partial class UserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role_id",
                column: "ConcurrencyStamp",
                value: "15db2c0d-c3c5-4227-8b07-728a2fd3bd8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student_role_id",
                column: "ConcurrencyStamp",
                value: "1c90a981-4f26-4915-80e5-51e03d8c2ae1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher_role_id",
                column: "ConcurrencyStamp",
                value: "cec5d143-3ea8-48f9-b027-ade81dbd6821");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5752f8f-0533-493e-9aac-eaf87603d0c2", "ADMIN@DATACLASS.ORG.UA", "AQAAAAEAACcQAAAAEItG3Wz0VzrwASeWiKtLLd/Cf2vGxSL+CK93OCY8GuvaEoMmdcrfDPnaz+17N2eIew==", "57701a0b-8c23-4665-8552-a64f68514e96" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role_id",
                column: "ConcurrencyStamp",
                value: "7b832bfb-4270-4ffa-9bd6-208b1e8862cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student_role_id",
                column: "ConcurrencyStamp",
                value: "44be9b8c-ca3a-41bc-b2ce-b30e39925718");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher_role_id",
                column: "ConcurrencyStamp",
                value: "a1b19808-0a93-4bba-8f5c-019e06a77fcb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eda31a63-3803-426a-938b-dab8093958aa", "ADMIN", "AQAAAAEAACcQAAAAEEMw8ITgAgSQZ5fEW7Sg/MXOQiQvYO4e6PElCi2X2GuUvHB4jZdXNcNEBOq3+S4sIA==", "aaacf749-1025-4de6-8ad1-4ba33397cbde" });
        }
    }
}
