using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class nesssfff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "7cdad413-e3d0-47fd-abbb-3c36c2e60552");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "dca24438-ea26-4708-862a-6b83f816c494");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "6e972977-3ded-46f8-9163-d55cf686190f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "4e84fa3c-b828-49c1-b269-56fe96644298");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2411c8ae-c311-4f72-a9b6-64e8e0d6adc7", "AQAAAAEAACcQAAAAEMW0QcbeVS+ZECK6f9C4byw9oM1Hqhk1/B9sKVpBnk3ajImG1cMI2dvIlv2VlKIl/g==", "fe402235-851a-48c8-ae1f-2c904fbe323b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "357434fe-e6e0-4235-b384-a093c03bf853", "AQAAAAEAACcQAAAAEGNzMkJXTDeb+Cnc6MDBqNmyLU/o7g2EFx8a5NSCYYkF1KgHODIbGn4Z2uWO3K3pZA==", "f9274997-8de7-42d4-b029-b5969651685d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd52e2bd-ee9d-4a7b-be04-bf297c1d6181", "AQAAAAEAACcQAAAAEP8IpJeI/H+6j3sz4iDkUkO9O1igmHTx1IBGvqxD3vC0t8tdORqHa6JdEKZBt9JyOQ==", "8e0aab12-ab7e-43d1-9c24-007237cd9499" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6917bbc-ffdf-40e5-9ec4-b2944c1b3160", "AQAAAAEAACcQAAAAEHdX9WBN5OBl0jeD3qgtn320JhToQYTn2H3pM6vhLMP7OCxkzo1RrmrKwDDXbkJFNA==", "b9a997dc-111d-4c21-b4e0-5fa7bcc12590" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 2, 26, 9, 40, 39, 71, DateTimeKind.Local).AddTicks(9823));
        }
    }
}
