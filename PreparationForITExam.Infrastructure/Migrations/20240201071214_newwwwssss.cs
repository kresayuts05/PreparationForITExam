using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class newwwwssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Materials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "e12163cf-cf23-4556-aed1-37198d80381c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "012639a6-2884-4230-bdae-2bd083ad657f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "8ecab0f1-c281-4e48-9c80-1b8f3eddf3c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "bfae65ac-022e-4644-805c-52cbfc6a08d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f38565f7-812e-40f5-b3ac-1fe71665fec2", "ab124ee8-bf21-4d36-9a74-1a3299899fa9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Materials",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "5f6729ca-5c3f-4f2e-bcf8-d4b4345811a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "20e4c8d1-17b0-4c3f-8d49-cdb45308a644");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "e095b7c5-a908-4e64-b436-58101eb357a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "d6885b21-b26d-4489-bdf4-336a0351695d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37d9a6d8-2b64-46ce-a152-682078822199", "5c40d918-3cfd-4afc-abb8-bf9d9a4fff44" });
        }
    }
}
