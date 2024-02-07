using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class userrole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "1665c666-e1f1-484f-ac74-8faadb64d2bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "17e2384e-13da-4ba3-a7d4-b12e1bfe68f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "0f10b0e9-29c5-4c12-b7e3-03c40b709b7f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "075f415b-3933-465e-a3e8-620b51dd1b16");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0f761db2-ab55-416c-83b9-70abded3d908", "789061a9-edaa-4a00-9e09-add6a20c8288" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9337d637-a31f-445d-bca6-dbc059105c6a", "AQAAAAEAACcQAAAAEADaw9V5iN/WhVETjPRWD5/9ZdGV14ko93O9a5TTrhUqn8RvfBu6pKKgmQtUMkE8UA==", "70ce6cf6-3c46-4197-9741-4823375ceb0a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0f761db2-ab55-416c-83b9-70abded3d908", "789061a9-edaa-4a00-9e09-add6a20c8288" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ddffb93-2781-4f1d-965d-6ea559d43844", "AQAAAAEAACcQAAAAEL2+Cu/3Jg3b4AbnbYH66RQkTdjoaybS5Jw1P0Ued7YFs0uZbrcM08c6aO8vgTjtNg==", "ead957c7-b4cb-40dc-a6ad-5dda70a139bb" });
        }
    }
}
