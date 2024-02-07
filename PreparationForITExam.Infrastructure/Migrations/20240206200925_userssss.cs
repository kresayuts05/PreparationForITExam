using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class userssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8107a12e-ba60-4679-8d55-4408b1fe0629", "AQAAAAEAACcQAAAAEJbDISeAg5NTFIXzp9eG5MR13FM4+HfVgT99xaC84WoddYUPpSlVXvJoY4k3b6OAYA==", "bb2fffdc-88e5-40fa-9f88-5db04d67aa65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "780ff608-3e21-4062-bcf8-3837a469c18c", null, "5441adb0-bc0e-4562-bd42-7b1a490dd171" });
        }
    }
}
