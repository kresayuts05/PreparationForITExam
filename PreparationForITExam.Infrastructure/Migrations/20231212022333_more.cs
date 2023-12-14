using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class more : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonMonUser_Lessons_LessonsId",
                table: "LessonMonUser");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonMonUser_MonUsers_MonsId",
                table: "LessonMonUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_SectionsOfCurricular_SectionOfCurricularId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "University",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "MonsId",
                table: "LessonMonUser",
                newName: "MonUserId");

            migrationBuilder.RenameColumn(
                name: "LessonsId",
                table: "LessonMonUser",
                newName: "LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonMonUser_MonsId",
                table: "LessonMonUser",
                newName: "IX_LessonMonUser_MonUserId");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SectionOfCurricularId",
                table: "Lessons",
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
                value: "cd233ccb-82a7-4cc8-99f1-0d872c39d477");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "6693c4a6-4972-4c89-96fe-93df7c5b3230");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "6dc34f6f-264f-4741-b6a2-b73e52a7b878");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "6423c417-3464-490c-9436-16c95ea8cb71");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "789061a9-edaa-4a00-9e09-add6a20c8288", 0, "Казанлък", "638c7562-884f-4a8e-a5e7-858b286ae6aa", "kresa@gmail.com", false, "Креса", true, "Цветкова", false, null, "KRESA@GMAIL.COM", "KRESA@GMAIL.COM", null, "0886121260", false, null, "a3ac6f8a-9dc3-4524-af10-20ac75ba93b5", false, "kresa@gmail.com" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Content", "ExerciseId", "IsActive", "SectionOfCurricularId", "Title" },
                values: new object[] { 1, "", 1, true, 1, "Компютърът" });

            migrationBuilder.InsertData(
                table: "SectionsOfCurricular",
                columns: new[] { "Id", "IsActive", "ModuleOfCurricularId", "Title" },
                values: new object[,]
                {
                    { 12, true, 3, "Въведение" },
                    { 13, true, 3, "Релационен модел на Бази от данни" },
                    { 14, true, 3, "Система за управление на Бази от данни" },
                    { 15, true, 3, "Интегриране на Бази от данни в интернет системи" },
                    { 17, true, 4, "Сървър за база от данни" },
                    { 18, true, 4, "Пабота по проекти" },
                    { 19, true, 4, "SQL SERVER със C#" }
                });

            migrationBuilder.InsertData(
                table: "MonUsers",
                columns: new[] { "Id", "IsActive", "UserId" },
                values: new object[] { 1, true, "789061a9-edaa-4a00-9e09-add6a20c8288" });

            migrationBuilder.InsertData(
                table: "LessonMonUser",
                columns: new[] { "LessonId", "MonUserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_LessonMonUser_Lessons_LessonId",
                table: "LessonMonUser",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonMonUser_MonUsers_MonUserId",
                table: "LessonMonUser",
                column: "MonUserId",
                principalTable: "MonUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_SectionsOfCurricular_SectionOfCurricularId",
                table: "Lessons",
                column: "SectionOfCurricularId",
                principalTable: "SectionsOfCurricular",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonMonUser_Lessons_LessonId",
                table: "LessonMonUser");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonMonUser_MonUsers_MonUserId",
                table: "LessonMonUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_SectionsOfCurricular_SectionOfCurricularId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "LessonMonUser",
                keyColumns: new[] { "LessonId", "MonUserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SectionsOfCurricular",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SectionsOfCurricular",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SectionsOfCurricular",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SectionsOfCurricular",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SectionsOfCurricular",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SectionsOfCurricular",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SectionsOfCurricular",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288");

            migrationBuilder.RenameColumn(
                name: "MonUserId",
                table: "LessonMonUser",
                newName: "MonsId");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "LessonMonUser",
                newName: "LessonsId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonMonUser_MonUserId",
                table: "LessonMonUser",
                newName: "IX_LessonMonUser_MonsId");

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Teachers",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SchoolId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SectionOfCurricularId",
                table: "Lessons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Lessons",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "76f823bf-dc74-4370-957d-59e07972195a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "1d8d74f0-4751-49e8-be95-615b7a9ae7e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "42f26007-d55a-4e77-9d56-e53e11f58d49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "355e20a2-60d6-4e92-adfa-d389ccd4cd11");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonMonUser_Lessons_LessonsId",
                table: "LessonMonUser",
                column: "LessonsId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonMonUser_MonUsers_MonsId",
                table: "LessonMonUser",
                column: "MonsId",
                principalTable: "MonUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_SectionsOfCurricular_SectionOfCurricularId",
                table: "Lessons",
                column: "SectionOfCurricularId",
                principalTable: "SectionsOfCurricular",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");
        }
    }
}
