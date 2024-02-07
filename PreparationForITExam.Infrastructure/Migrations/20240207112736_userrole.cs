using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class userrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "6a5a9d07-a781-46a0-a4b5-ce98c89f97e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "cefba318-9691-431b-a01b-401a325ca741");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "2c0787f7-8734-4796-8332-2a907a8d5373");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "989ef273-276c-40e7-9d78-9a0e52252901");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleName", "SecurityStamp" },
                values: new object[] { "8ddffb93-2781-4f1d-965d-6ea559d43844", "AQAAAAEAACcQAAAAEL2+Cu/3Jg3b4AbnbYH66RQkTdjoaybS5Jw1P0Ued7YFs0uZbrcM08c6aO8vgTjtNg==", "Administrator", "ead957c7-b4cb-40dc-a6ad-5dda70a139bb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "ab8a7305-d38d-42a6-b3e4-5fb24a0086df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "2b4348c9-4df9-435a-881f-df4a98811c77");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "4af15ff7-eb0f-4f0d-8a5a-a87545f4f812");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "f2fa62f6-7a6e-40a9-84a3-869f3dd8e5d4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RoleName", "SecurityStamp" },
                values: new object[] { "8107a12e-ba60-4679-8d55-4408b1fe0629", "AQAAAAEAACcQAAAAEJbDISeAg5NTFIXzp9eG5MR13FM4+HfVgT99xaC84WoddYUPpSlVXvJoY4k3b6OAYA==", "administrator", "bb2fffdc-88e5-40fa-9f88-5db04d67aa65" });
        }
    }
}
