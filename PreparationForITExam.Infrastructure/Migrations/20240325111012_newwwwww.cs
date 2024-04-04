using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class newwwwww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "8b522af0-bbf0-4825-8f8e-db7beec52f0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "df1de11e-877c-444a-8530-6662a4e838aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "5bed423b-10b4-4a43-9b0c-3c23fbcd35b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "300f1420-46d4-43c7-b2ff-524d739e6ebb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64ed22da-55e7-4f02-9b58-b1b7f99a40f1", new DateTime(2024, 3, 25, 11, 10, 11, 654, DateTimeKind.Utc).AddTicks(7707), "AQAAAAEAACcQAAAAENjiL8WKObegamjIK+W74s8v1G/60v8dAHlHcsEq8UxmLPifLSHPqfpj6RuQ/+seLA==", "cac8c8a0-aa24-47d5-a0c3-80c25308d2c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26267169-65df-4cbd-8a2b-15d283f4f0df", new DateTime(2024, 3, 25, 11, 10, 11, 649, DateTimeKind.Utc).AddTicks(5500), "AQAAAAEAACcQAAAAEAkPvGWwrM+Fc7kF9M1OmnTjlh0cCADQq7v/tI2AcB8/KtaRBYaKfSfweKWVFy4ESQ==", "c53a0ba8-7c12-4f21-9a54-c104b119870d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64932fae-6872-4304-8fce-f42c0a9beb42", new DateTime(2024, 3, 25, 11, 10, 11, 653, DateTimeKind.Utc).AddTicks(3725), "AQAAAAEAACcQAAAAEBxGdmz6BOJSyC3s9xfHGgcwDWm3GeE1oVRhHB9/a3VoKCkAMNWksEc/MivpxzYyWA==", "6918c225-e26c-4128-a3b0-59c001510543" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59bb6bfd-0935-4cf8-9b9b-63ce54d97352", new DateTime(2024, 3, 25, 11, 10, 11, 656, DateTimeKind.Utc).AddTicks(1242), "AQAAAAEAACcQAAAAECTzbX08CPnWmZSvUc5BdeHWFK5rQqdNUVQVHEMd/FF/HFXjKxfITSPZFjp9k0+3Bw==", "0c0d9669-4302-4c29-81eb-f775ff4b87cc" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 717, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 717, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 717, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 3, 25, 13, 10, 11, 718, DateTimeKind.Local).AddTicks(7657));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "3002c66c-072d-4a73-a4e8-31947f352ffd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "3157a9e3-7dc8-4067-a8d2-8a02983662c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "f2960b21-7e0b-424c-9ab2-d8fc4aad9340");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "e680e75c-0882-4cbd-89dc-76d33024f62b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2b3d417-8171-4ade-953d-6b9ecb5cc5b8", "AQAAAAEAACcQAAAAEIr82HsrVchB0EH+WtgqpRL4eaf9SysTxQYfZZM6T+gNJyDO+/x/cqQozWe+ZhzlGg==", "a904ba60-e80a-40dc-bc65-2ee70e557cf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "baff56a0-78f9-4bdc-b700-1c4426bcabc1", "AQAAAAEAACcQAAAAEEXgH7WeMEDVMcXLcFojXS6M5IXtnnZE8t+IpZXLrZK/TxspdEqfE8fhQ3jsaHB1ag==", "e56b3e9b-d7eb-4bb2-b7f6-08a8f8e5953d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed418f04-e4ac-44e2-8b12-b5d98b53108d", "AQAAAAEAACcQAAAAECjtvdDg+xcCp1o4zK/3dG5EfLvQZ829CmyJFoiek8zURDVwIf53aN7tIEFrSiBTqw==", "a4a2d695-480f-4f46-98c5-bf2e6bbc54e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84b86da9-22db-4480-b26d-13bdc9919187", "AQAAAAEAACcQAAAAEPsHRQRJHsWqcTG8IWSEU4J4cEkF/obN3RKWtcSh64im7KY/J/f/1Ohwzo35tDdrqA==", "bb9838e5-e150-432b-9769-2d59df220029" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 2, 29, 9, 18, 20, 887, DateTimeKind.Local).AddTicks(725));
        }
    }
}
