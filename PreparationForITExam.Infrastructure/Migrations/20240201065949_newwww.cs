using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class newwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "Materials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "07eecaa1-4b37-4365-a6a2-3fc1dad9298c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "5556ea24-4516-49b4-a11e-b018a24b2a11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "4c9ebcca-eb97-4c7f-874b-b122f7b88fbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "20291427-06bc-437d-9a30-8209c1f87121");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9a04820-3dde-4df3-8b9a-858f59d5908f", "2e489419-10bf-4960-bf51-1d28016cb07f" });

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Lessons_LessonId",
                table: "Materials",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id");
        }
    }
}
