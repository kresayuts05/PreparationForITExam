using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class sgggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "c22b747d-a4b5-486d-9c61-045e97e45f3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "ef3ca292-0bcb-4028-aa7b-b0aed8c6d91f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "e52cbf2c-034e-4fd5-bb7b-2d3d2a9b0720");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "e73d8a0f-ac89-46a2-b82d-cde609486c81");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bfd6b95-9dd2-4d3e-8b8d-8fb4e0624b8e", new DateTime(2024, 4, 9, 8, 8, 22, 756, DateTimeKind.Utc).AddTicks(8746), "AQAAAAEAACcQAAAAEO+ByIy/qYOgCP/Q4iD2a0lTRcC05BjgefBwNmGdnMJT9+UECOMHXflJX9sl2kGl9Q==", "a19b5f3c-d4b6-411c-b548-9e4c8310fe1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b41fab3-98d7-44f1-88ef-cf59806c948b", new DateTime(2024, 4, 9, 8, 8, 22, 753, DateTimeKind.Utc).AddTicks(1043), "AQAAAAEAACcQAAAAEIIbCWgwmQ0hlq1l/wHWP906OiKP5YQc8pUJKkWs2K4M8IyPAP2av2kESfrKc7A1qA==", "cc5654ce-735c-4afc-b396-53658694e0ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79600174-845e-4a89-a521-81a84da01c61", new DateTime(2024, 4, 9, 8, 8, 22, 755, DateTimeKind.Utc).AddTicks(9242), "AQAAAAEAACcQAAAAELflmm3C3x1X4ac0rn98HtbGmgfy2T2w7D/Ac076ZEZKWeVVoNzDHoXIwoRBditCYA==", "df8f03eb-181f-4858-8bc0-e11f36df2fea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f300da42-9bcb-4830-8b8b-4e01d39a7d44", new DateTime(2024, 4, 9, 8, 8, 22, 757, DateTimeKind.Utc).AddTicks(8113), "AQAAAAEAACcQAAAAEPb4xb5S6orh9HNwvpMJQIIGEhkAjkQEiQOEtR9ONqzecigXqMKDcL5u0Lpny5hl3g==", "d96c39c4-6ae3-43d3-8c7b-a584c10a6b67" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 4, 9, 11, 8, 22, 779, DateTimeKind.Local).AddTicks(9074));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
