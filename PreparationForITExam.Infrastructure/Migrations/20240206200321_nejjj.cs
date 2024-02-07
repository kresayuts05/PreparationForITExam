using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class nejjj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "AspNetUsers",
                type: "nvarchar(700)",
                maxLength: 700,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "9d835de2-542e-434d-a8d4-91ff714fc865");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "0aedbb4e-ffa3-4656-bd29-1ee9643d8025");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "8128b1df-3814-490f-a57c-1c584eb53f6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "ee31c54d-fc6d-4673-a3ab-a48c9357981a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "780ff608-3e21-4062-bcf8-3837a469c18c", "5441adb0-bc0e-4562-bd42-7b1a490dd171" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutMe",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "AboutMe",
                table: "Teachers",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "11a740ce-6e0c-4b90-8030-088f01b699dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "b1901a92-d4ec-49aa-8e38-26d9f1131ceb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "18bf6760-ea62-41bf-b5d3-02615c81eee2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "616d3c3d-6907-4941-a2e9-e41ce3407996");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b18e2c08-3fc4-49a6-b45a-23256d379d9d", "a5209cd9-83f1-4050-ab30-2135aba3a19d" });
        }
    }
}
