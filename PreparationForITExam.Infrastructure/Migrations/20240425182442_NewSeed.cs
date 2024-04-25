using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreparationForITExam.Infrastructure.Migrations
{
    public partial class NewSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "ace0d158-9671-45b2-8291-185570228a96");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "8fa4b290-1894-4d86-9ca1-df57598e5c23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "16a1d50e-ad47-4457-b121-f15f2978b115");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "3150fc87-bf8a-4dd1-8823-5a511ed4bb1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23b4377b-8daa-4268-ba80-c703e93affed", new DateTime(2024, 4, 25, 18, 24, 41, 312, DateTimeKind.Utc).AddTicks(194), "AQAAAAEAACcQAAAAEA0eksuHGWC5+C80tLodiEEAeXiXaHHJYVgYrILnepQkyw3MyR96V1/7cwVfYNhtoA==", "5d9f43c5-e93d-467c-ba18-c4c2d0454c79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d819cac4-9118-4298-8094-8334b9bc46f2", new DateTime(2024, 4, 25, 18, 24, 41, 309, DateTimeKind.Utc).AddTicks(7293), "AQAAAAEAACcQAAAAEPfW5iZfRQiRRdssMV95Vym0F0aW8G+EPmnm8tBu22nL2c2+YrTWYohmPhIw+tppFg==", "1df80ebd-4d92-4d85-a47c-986df6889c9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bceb20fa-3583-41ba-b702-bcb3933fcb08", new DateTime(2024, 4, 25, 18, 24, 41, 310, DateTimeKind.Utc).AddTicks(8698), "AQAAAAEAACcQAAAAEANlYYdtmCh1HOyXenCXj65v5bYrFHS364o1YwQnI41kWAEiIMfAkFLr6qSpMmI7tg==", "040415d1-8cad-4ab0-b79e-f65157f797e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "914b8199-dcb9-4b7d-9807-3b03756bf3b3", new DateTime(2024, 4, 25, 18, 24, 41, 313, DateTimeKind.Utc).AddTicks(1243), "AQAAAAEAACcQAAAAEInaMfnmc+G0NzJxXGTMpaiH0Twaq9vqFXUhHTK8T72vvkDH0xgNP95zjoUi1ZJeHg==", "a8b5aa0c-8efc-416c-8b88-58aea1fc01be" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 21, 24, 41, 314, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714065745/Screenshot_2024-04-25_202139_dtmv9i.png" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "IsActive", "IsFreeAnswer", "RightAnswer", "UserId" },
                values: new object[,]
                {
                    { 2, 6, "Ако знаете, че ASCII кодът на буквата 'a' е 97, кой от низовте ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714066118/Screenshot_2024-04-25_202822_wyk7lf.png", true, true, "bnbajoh", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 3, 8, "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714066826/Screenshot_2024-04-25_203444_ygxcbt.png", true, true, "9", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 4, 11, "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714066882/Screenshot_2024-04-25_204000_yv4gms.png", true, true, "4", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 5, 2, "Каква е причината за грешката в следния програмен фрагмент?", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714067374/Screenshot_2024-04-25_204915_wme5tz.png", true, true, "Не може да се променя списакът по време на итерация на foreach цикъла;", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 6, 1, "Коя от следните стойности може да се присвои на променлива от тип ushort?", null, true, true, "'5'", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 7, 3, "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714067739/Screenshot_2024-04-25_205521_nfioem.png", true, true, "4 5 5.74", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 8, 5, "Какъв тип данни връща методът Next() на класа System.Random при генериране на случайно число?", null, true, true, "int", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 9, 20, "Трябва да създадете приложение с графичен потребителски интерфейс, в което човек трябва да попълни информация. Необходимо е да определи какви занимания са му любими, като избере колкото желае от 5 посочени възможност. С какви елементи на потребителския интерфейс да се визуализират заниманията?", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714067739/Screenshot_2024-04-25_205521_nfioem.png", true, true, "полета  за отметка (check boxes)", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 10, 20, "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714068288/Screenshot_2024-04-25_210424_yiywpw.png", true, true, "3", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 11, 17, "В проект е създаден клас със статичен метод:", "https://res.cloudinary.com/dmv8nabul/image/upload/v1714068480/Screenshot_2024-04-25_210746_lm3lcr.png", true, true, "Console.WriteLine(Sequence.Fibonacci(7));", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 12, 25, "На кой етап от жизнения цикъл на информационна система се избират технологиите, които ще се използват и стандарта за писане на код?", null, true, true, "анализ и дефиниция", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" },
                    { 13, 21, "Релационна база от данни за туристическа агенция съдържа няколко таблици. Едната от таблиците дава информация за клиентите на агенцията, а друга за нейните дестинации на пътувания. За да се отрази правилно дейността на агенцията, тези две таблици трябва:", null, true, true, "да са свързани с връзка „много към много“ чрез допълнителна таблица;", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "IsActive", "IsFreeAnswer", "RightAnswer", "UserId" },
                values: new object[] { 14, 10, "Каква е основната разлика между ArrayList и обикновенния масив (array) в C#?", null, true, true, "ArrayList автоматично разширява размера си при добавяне на нови елементи, докато обикновният масив има фиксиран размер", "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc" });

            migrationBuilder.InsertData(
                table: "QuestionAnswers",
                columns: new[] { "Id", "IsActive", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 5, true, 2, "bnbajoh" },
                    { 6, true, 2, "cocbkpi" },
                    { 7, true, 2, "bnbajog" },
                    { 8, true, 2, "cocblpi" },
                    { 9, true, 3, "16" },
                    { 10, true, 3, "31" },
                    { 11, true, 3, "12" },
                    { 12, true, 3, "9" },
                    { 13, true, 4, "1" },
                    { 14, true, 4, "2" },
                    { 15, true, 4, "4" },
                    { 16, true, 5, "Не може към списък с елементи от тип int да добавяме елементи от тип char;" },
                    { 17, true, 5, "Не може с цикъл foreach да се обхождат елементи на списък от тип char;" },
                    { 18, true, 5, "Не може да се променя списакът по време на итерация на foreach цикъла;" },
                    { 19, true, 5, "Не може да изтриваме елементи от списък;" },
                    { 20, true, 6, "-567" },
                    { 21, true, 6, "0.8" },
                    { 22, true, 6, "67500" },
                    { 23, true, 6, "'5'" },
                    { 24, true, 7, "5 0 3.74" },
                    { 25, true, 7, "4 5 5.74" },
                    { 26, true, 7, "4 5 5.75" },
                    { 27, true, 7, "4 0 3.75" },
                    { 28, true, 8, "int" },
                    { 29, true, 8, "double" },
                    { 30, true, 8, "float" },
                    { 31, true, 8, "string" },
                    { 32, true, 9, "радио бутони (radio buttons)" },
                    { 33, true, 9, "полета  за отметка (check boxes)" },
                    { 34, true, 9, "списъчно поле (list box)" },
                    { 35, true, 9, "падащ списък (combo box)" },
                    { 36, true, 10, "0" },
                    { 37, true, 10, "1" },
                    { 38, true, 10, "3" },
                    { 39, true, 10, "7" },
                    { 40, true, 11, "Sequence sequence = new Sequence();\r\nConsole.WriteLine(sequence.Fibonacci(7));" },
                    { 41, true, 11, "Console.WriteLine(Sequence.Fibonacci(7));" },
                    { 42, true, 11, "Console.WriteLine(Fibonacci(7));" },
                    { 43, true, 11, "Console.WriteLine(Sequence(7));" },
                    { 44, true, 12, "анализ и дефиниция" },
                    { 45, true, 12, "проектиране" },
                    { 46, true, 12, "разработка" }
                });

            migrationBuilder.InsertData(
                table: "QuestionAnswers",
                columns: new[] { "Id", "IsActive", "QuestionId", "Value" },
                values: new object[,]
                {
                    { 47, true, 12, "тестване" },
                    { 48, true, 13, "да са свързани с връзка „едно към едно“;" },
                    { 49, true, 13, "да са свързани с връзка „едно към много“;" },
                    { 50, true, 13, "да са свързани с връзка „много към много“ чрез допълнителна таблица;" },
                    { 51, true, 13, "да не бъдат свързвани." },
                    { 52, true, 14, "ArrayList може да съдържа елементи само от типове string и int, докато обикновният масив е ограничен до елементи от един и същи тип" },
                    { 53, true, 14, "ArrayList поддържа генеричност, докато обикновният масив не" },
                    { 54, true, 14, "ArrayList е част от пространството от имена System.Collections, докато обикновният масив е част от пространството от имена System.Collections.Generic" },
                    { 55, true, 14, "ArrayList автоматично разширява размера си при добавяне на нови елементи, докато обикновният масив има фиксиран размер" },
                    { 56, true, 4, "3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "QuestionAnswers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f761db2-ab55-416c-83b9-70abded3d908",
                column: "ConcurrencyStamp",
                value: "3e0a9f5a-0723-4e2f-b9ba-bdb05f7d5f81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71281cf3-9730-4d7e-acbb-213edee8291c",
                column: "ConcurrencyStamp",
                value: "9f50fd0a-7652-40df-b27b-908bfd02d4cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e66d730b-bcf1-41b5-b7e0-3e66056e61d9",
                column: "ConcurrencyStamp",
                value: "033c81b1-9da4-4dd2-ac2d-3fef05261d55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                column: "ConcurrencyStamp",
                value: "42e06581-cbb3-4eb3-b067-7604e6165d3e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71c9e430-b3bd-4493-9722-48baaa0740bd", new DateTime(2024, 4, 25, 16, 51, 2, 180, DateTimeKind.Utc).AddTicks(9102), "AQAAAAEAACcQAAAAEPqs9Fg3uQ+X9+IP+jBo5mSfhXweBgPcnpkYkDRTI1Ldh3trDPxFx4R9/rWsPBQdeQ==", "850ee410-bc9e-434c-8ac3-3e313de0232f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789061a9-edaa-4a00-9e09-add6a20c8288",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1c9db61-7ac9-4d8f-b173-e9f3f0bc63c8", new DateTime(2024, 4, 25, 16, 51, 2, 178, DateTimeKind.Utc).AddTicks(8348), "AQAAAAEAACcQAAAAELo1ImO/fAKC151tiDtBBOeuIm/xAg6jPHYKZyiiAHkhZacHabsJR5o9X2MXLdDmpQ==", "393edcf3-b075-4d75-b5d8-12eae858b04d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7713a6a-d00c-4b43-b590-18693d42bf8e", new DateTime(2024, 4, 25, 16, 51, 2, 179, DateTimeKind.Utc).AddTicks(9063), "AQAAAAEAACcQAAAAEJJATBFTCG3/6p06WSdlfJgj2Wwf8wYa+QOTd9Z4PRjY25QXXYCzQ6Py2ovsIxB30w==", "830403f8-577b-4eb1-97e3-5a3911e9a931" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "PasswordHash", "SecurityStamp" },
                values: new object[] { "453cdea3-292a-46d3-970d-81de152a883d", new DateTime(2024, 4, 25, 16, 51, 2, 181, DateTimeKind.Utc).AddTicks(9023), "AQAAAAEAACcQAAAAELCVmb0moOWali4hu6wLsj2pJHadf7XSXoFCj2DQgkv136qOL2hVMpNrbEM/jpqnaA==", "951657a0-a795-4f67-8101-9b9dd27c9067" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PostedOn",
                value: new DateTime(2024, 4, 25, 19, 51, 2, 183, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image" },
                values: new object[] { "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:\r\nint number = 127;\r\nint count = 0;\r\ndo\r\n{\r\nif(number<20)\r\n{\r\n  number /=3;\r\n}\r\nelse \r\n{ \r\n  number-=20;\r\n}\r\ncount++;\r\n}\r\n", null });
        }
    }
}
