using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class ModulesOdCurr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModuleOfCurricularId",
                table: "SectionsOfCurricular",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ModuleOfCurricular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleOfCurricular", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "16dd93a3-dff7-4f09-b7a6-e883a08a540f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "582ee78c-9568-4476-bb65-fd172f2cf20b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "a433c39a-6fb4-48f2-89f9-2f79cff37c99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "c9424e66-956e-452a-942d-e0ef5bfd5479");

            migrationBuilder.CreateIndex(
                name: "IX_SectionsOfCurricular_ModuleOfCurricularId",
                table: "SectionsOfCurricular",
                column: "ModuleOfCurricularId");

            migrationBuilder.AddForeignKey(
                name: "FK_SectionsOfCurricular_ModuleOfCurricular_ModuleOfCurricularId",
                table: "SectionsOfCurricular",
                column: "ModuleOfCurricularId",
                principalTable: "ModuleOfCurricular",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SectionsOfCurricular_ModuleOfCurricular_ModuleOfCurricularId",
                table: "SectionsOfCurricular");

            migrationBuilder.DropTable(
                name: "ModuleOfCurricular");

            migrationBuilder.DropIndex(
                name: "IX_SectionsOfCurricular_ModuleOfCurricularId",
                table: "SectionsOfCurricular");

            migrationBuilder.DropColumn(
                name: "ModuleOfCurricularId",
                table: "SectionsOfCurricular");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "6e66dc87-faf8-42ef-88ab-97a83a451d5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "ef6fe581-88d2-4e85-956e-8172e0e431ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "8052fe2e-e4fd-4d59-81b7-f6fdfc9eee1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "a0213fe0-992f-4f99-811a-f2b51a1a0c24");
        }
    }
}
