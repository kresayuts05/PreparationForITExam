using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "932269ef-54a6-419c-a102-0240f5af62e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "2af77af8-46d1-4feb-b378-e3d80f747440");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "a81b5407-5c05-4c1d-9ed9-ff543993db12");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "7467b5c4-b91d-4d86-8c2f-cfe5ba52cdc4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9b12274-acf1-42f7-afc4-e7b0513dc4cc", "AQAAAAEAACcQAAAAEM826is3qi+1yZEfJkNMyIZvad0XJwX0EMO2pTYZ5Iu5Dcwjyoa3oF58U/9LIrUgUw==", "afa0991d-109a-4eb4-a89f-3e0a5716e4dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55e3ba01-b8b9-401c-8232-13cab466f478", "AQAAAAEAACcQAAAAEDgos2vBX5QeWAlI8gddKZPTGObZ1wZ9WRsIanIJqW+YjvDRytEYDVCwokzXSh8oUA==", "82f7cb84-9b81-42ff-9ab6-8e021a01326c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "207621ac-6376-47f6-a01c-b4df082c4499", "AQAAAAEAACcQAAAAEBNfM39R2kaoBL6cDyoNpqc3B7ys3J31dXIUAEqRc3wx15r0mEtooRB4YyrstWSEgA==", "05b37c99-e095-4e17-ab4a-84dba759483d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0909d740-d524-470c-9249-1b9c82bd91ad", "AQAAAAEAACcQAAAAECZNHTyv81y+gYbB/xT8NuiOXc82t7+SmZpH1A79zcV4NHNb5Vp6obPtHyeHy98HIg==", "931156fb-b2cd-4927-9f2e-9f00a736937f" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 3, 10, 39, 286, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "PostId1",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "fc0bc7b9-7c41-4a23-a382-768cd46c61a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "a349948b-618e-483a-8c43-f607a6bc360f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "d9e3c3a0-6985-4c3a-8359-bc7b538a5c35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "a9c5eb55-6085-4390-804a-1577586767ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70c7e193-db16-4148-bd00-3df44179534c", "AQAAAAEAACcQAAAAEK6D/SWx20mJ4xEfzzlexQx6y5kpZpbKlqqRShWPndx79er0wSDPhQEChqz7Gyitrg==", "5d5da8f9-61b5-4a01-ad48-bed37c62e00f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a0d0fbc-35ce-4eae-af48-1cb12eeb7ff4", "AQAAAAEAACcQAAAAEDwicZjJTiX+TKMCcByh8aKt03kdgLEC8fODyU8IfTVzNTSQecosi4iWM3vlUJt/Vw==", "07314d04-9561-4872-98e0-38060fb915e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa93127c-6590-40b8-97a9-4cf98beeb13f", "AQAAAAEAACcQAAAAEHyxsdPACwrwiBhDPOqM23rRxA5rOfgzCQGnjZMjF8p6W1xvG6r4hgPppdc2h497MQ==", "0bd50cd8-6d5c-4057-9144-33da373a91f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd10e382-3f64-41e3-9fdd-a91311936c7b", "AQAAAAEAACcQAAAAEE1bQ9sSCUUqXDSqSYUkCQhOwWWnk52808MTeZZ51gTB6uIxKJodvpgtPFdmoZ1QsA==", "bacd656d-deb5-4ef7-b632-6e6567d3a532" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 2, 24, 1, 17, 20, 323, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId1",
                table: "Comments",
                column: "PostId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId1",
                table: "Comments",
                column: "PostId1",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
