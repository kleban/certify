using Microsoft.EntityFrameworkCore.Migrations;

namespace Certify.Core.Migrations
{
    public partial class user_names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Certificates",
                newName: "StudentLastName");

            migrationBuilder.AddColumn<string>(
                name: "StudentFirstName",
                table: "Certificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentFirstName",
                table: "Certificates");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "StudentLastName",
                table: "Certificates",
                newName: "StudentName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin_role_id",
                column: "ConcurrencyStamp",
                value: "9ee61efd-a44c-46da-98b7-fe2a4b56f398");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "student_role_id",
                column: "ConcurrencyStamp",
                value: "f2d2fada-21c8-4260-94ff-774bc5f462b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "teacher_role_id",
                column: "ConcurrencyStamp",
                value: "05c2627c-1b9f-4ed8-a2b0-ebd9899ab472");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_user_id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb69b117-b6ca-4667-a37b-dbb8a15669fd", "AQAAAAEAACcQAAAAEBBXoBfs3CQjMW6KOMYKn/Gpd9wL31OHCGN4T+vN2/DL5W2urQYxgDPU5zDKG/P21w==", "8902f247-c7ab-4dce-8230-e1160b996213" });
        }
    }
}
