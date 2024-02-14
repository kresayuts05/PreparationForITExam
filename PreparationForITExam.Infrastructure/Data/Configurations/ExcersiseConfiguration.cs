using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Configurations
{
    public class ExcersiseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasData(new List<Exercise>
            {
              new Exercise
                {
                    Id = 1,
                    Title = "Компютърът",
                    SectionOfCurricularId = 1,
                    Content = "",
                },
                new Exercise
                {
                    Id = 2,
                    Title = "Езици за програмиране",
                    SectionOfCurricularId = 1,
                    Content = "",
                },
                new Exercise
                {
                    Id = 3,
                    Title = "Инструменти и IDE",
                    SectionOfCurricularId = 1,
                    Content = "",
                },
                new Exercise
                {
                    Id = 4,
                    Title = "IDE Visual Studio",
                    SectionOfCurricularId = 1,
                    Content = "",
                },
                new Exercise
                {
                    Id = 5,
                    Title = "Елементи на програмата",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 6,
                    Title = "Основни типове операции и оператори",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 7,
                    Title = "Изчислителни процеси. Линейни процеси",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 8,
                    Title = "Линейни изчислителни процеси. Упражнение",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 9,
                    Title = "Сравнения и логически операции",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 10,
                    Title = "Разклонени изчислителни процеси",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 11,
                    Title = "Циклични изчислителни процеси",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 12,
                    Title = "Оператори за цикъл с условие",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 13,
                    Title = "Оператори за цикъл. Упражнение",
                    SectionOfCurricularId = 2,
                    Content = "",
                },
                new Exercise
                {
                    Id = 14,
                    Title = "Обекти и класове от обекти",
                    SectionOfCurricularId = 3,
                    Content = "",
                },
                new Exercise
                {
                    Id = 15,
                    Title = "Класове",
                    SectionOfCurricularId = 3,
                    Content = "",
                },
                new Exercise
                {
                    Id = 16,
                    Title = "Клас с контролирани атрибути",
                    SectionOfCurricularId = 3,
                    Content = "",
                },
                new Exercise
                {
                    Id = 17,
                    Title = "Функции и методи",
                    SectionOfCurricularId = 3,
                    Content = "",
                },
                new Exercise
                {
                    Id = 18,
                    Title = "Конструктори",
                    SectionOfCurricularId = 3,
                    Content = "",
                },
                new Exercise
                {
                    Id = 19,
                    Title = "Предаване на аргументи",
                    SectionOfCurricularId = 3,
                    Content = "",
                },
                new Exercise
                {
                    Id = 20,
                    Title = "Упражнение",
                    SectionOfCurricularId = 3,
                    Content = "",
                },
                new Exercise
                {
                    Id = 21,
                    Title = "Елементи на графичние интерфейс",
                    SectionOfCurricularId = 4,
                    Content = "",
                },
                new Exercise
                {
                    Id = 22,
                    Title = "Графични компоненти",
                    SectionOfCurricularId = 4,
                    Content = "",
                },
                new Exercise
                {
                    Id = 23,
                    Title = "Упражнение",
                    SectionOfCurricularId = 4,
                    Content = "",
                },
                new Exercise
                {
                    Id = 24,
                    Title = "Упражнение",
                    SectionOfCurricularId = 4,
                    Content = "",
                },
                new Exercise
                {
                    Id = 25,
                    Title = "Агрегатни типове",
                    SectionOfCurricularId = 4,
                    Content = "",
                },
                new Exercise
                {
                    Id = 26,
                    Title = "Файлове",
                    SectionOfCurricularId = 4,
                    Content = "",
                },
                new Exercise
                {
                    Id = 27,
                    Title = "Четене на обекти от файл",
                    SectionOfCurricularId = 4,
                    Content = "",
                },
                new Exercise
                {
                    Id = 28,
                    Title = "Документиране на клас. Сериализация",
                    SectionOfCurricularId = 5,
                    Content = "",
                },
                new Exercise
                {
                    Id = 29,
                    Title = "Капсулиране. Статични атрибути и методи",
                    SectionOfCurricularId = 5,
                    Content = "",
                },
                new Exercise
                {
                    Id = 30,
                    Title = "Йерархия от класове",
                    SectionOfCurricularId = 5,
                    Content = "",
                },
                new Exercise
                {
                    Id = 31,
                    Title = "Полиморфизъм",
                    SectionOfCurricularId = 5,
                    Content = "",
                },
                new Exercise
                {
                    Id = 32,
                    Title = "Абстракция класове. Интерфейси",
                    SectionOfCurricularId = 5,
                    Content = "",
                },
                new Exercise
                {
                    Id = 33,
                    Title = "Изключения",
                    SectionOfCurricularId = 5,
                    Content = "",
                },
                new Exercise
                {
                    Id = 34,
                    Title = "Информация и данни",
                    SectionOfCurricularId = 12,
                    Content = "",
                },
                new Exercise
                {
                    Id = 35,
                    Title = "Информационни системи и процеси",
                    SectionOfCurricularId = 12,
                    Content = "",
                },
                new Exercise
                {
                    Id = 36,
                    Title = "Файлов подход и подход с бази от данни",
                    SectionOfCurricularId = 12,
                    Content = "",
                },
                new Exercise
                {
                    Id = 37,
                    Title = "Упражнение",
                    SectionOfCurricularId = 12,
                    Content = "",
                },
                new Exercise
                {
                    Id = 38,
                    Title = "Множества и релации",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 39,
                    Title = "Релационна база от данни",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 40,
                    Title = "Операции с релации",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 41,
                    Title = "Типове данни с релации",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 42,
                    Title = "Типове данни. Ключове",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 43,
                    Title = "Нормализация",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 44,
                    Title = "Модел обект-взаимодействие",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 45,
                    Title = "Нива на абстракция. Аномалии",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 46,
                    Title = "Проектиране на БД. Упражнение",
                    SectionOfCurricularId = 13,
                    Content = "",
                },
                new Exercise
                {
                    Id = 47,
                    Title = "Програмата MS Access",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 48,
                    Title = "Езикът SQL. Заявки",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 49,
                    Title = "Заявка SELECT",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 50,
                    Title = "Клаузите ORDER BY и GROUP BY",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 51,
                    Title = "Екранни форми. Контрол на данните",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 52,
                    Title = "Търсене на данни",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 53,
                    Title = "Създаване и редактиране на таблици със SQL",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 54,
                    Title = "Упражнение",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 55,
                    Title = "Отчети",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 56,
                    Title = "Връзки между таблиците. Съединиение",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 57,
                    Title = "Влагане на заявки",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 58,
                    Title = "Упражнение",
                    SectionOfCurricularId = 14,
                    Content = "",
                },
                new Exercise
                {
                    Id = 59,
                    Title = "Интегриране на БД в MS Access",
                    SectionOfCurricularId = 15,
                    Content = "",
                },
                new Exercise
                {
                    Id = 60,
                    Title = "Интегриране на БД със C#",
                    SectionOfCurricularId = 15,
                    Content = "",
                },
                new Exercise
                {
                    Id = 61,
                    Title = "Упражнение",
                    SectionOfCurricularId = 15,
                    Content = "",
                },
                new Exercise
                {
                    Id = 62,
                    Title = "Алгоритми",
                    SectionOfCurricularId = 6,
                    Content = "",
                },
                new Exercise
                {
                    Id = 63,
                    Title = "UML-диаграми упражнение",
                    SectionOfCurricularId = 6,
                    Content = "",
                },
                new Exercise
                {
                    Id = 64,
                    Title = "Сложност на алгоритми",
                    SectionOfCurricularId = 6,
                    Content = "",
                },
                new Exercise
                {
                    Id = 65,
                    Title = "Обектно-ориентирано програмиране - преговор",
                    SectionOfCurricularId = 6,
                    Content = "",
                },
                new Exercise
                {
                    Id = 66,
                    Title = "Реализация на алгоритми чрез методи",
                    SectionOfCurricularId =6,
                    Content = "",
                },
                new Exercise
                {
                    Id = 67,
                    Title = "Рекурсия и интеграция",
                    SectionOfCurricularId = 6,
                    Content = "",
                },
                new Exercise
                {
                    Id = 68,
                    Title = "Сложност на програми",
                    SectionOfCurricularId = 6,
                    Content = "",
                },
                new Exercise
                {
                    Id = 69,
                    Title = "Едномерен масив - преговор",
                    SectionOfCurricularId = 7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 70,
                    Title = "Сортиране на масив",
                    SectionOfCurricularId = 7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 71,
                    Title = "Работа със сортирани масиви",
                    SectionOfCurricularId =7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 72,
                    Title = "Сортиране на масив",
                    SectionOfCurricularId = 7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 73,
                    Title = "Работа със сортирани масиви",
                    SectionOfCurricularId =7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 74,
                    Title = "Низове",
                    SectionOfCurricularId =7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 75,
                    Title = "Масиви от знаци",
                    SectionOfCurricularId =7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 76,
                    Title = "Многомерни масиви",
                    SectionOfCurricularId = 7,
                    Content = "",
                },
                new Exercise
                {
                    Id = 77,
                    Title = "Основни понятия",
                    SectionOfCurricularId = 8,
                    Content = "",
                },
                new Exercise
                {
                    Id = 78,
                    Title = "Вградени АТ в C#",
                    SectionOfCurricularId =8,
                    Content = "",
                },
                new Exercise
                {
                    Id = 79,
                    Title = "Списъци",
                    SectionOfCurricularId = 8,
                    Content = "",
                },
                new Exercise
                {
                    Id = 80,
                    Title = "Опашки",
                    SectionOfCurricularId = 8,
                    Content = "",
                },
                new Exercise
                {
                    Id = 81,
                    Title = "Стек",
                    SectionOfCurricularId =8,
                    Content = "",
                },
                new Exercise
                {
                    Id = 82,
                    Title = "Упражнение",
                    SectionOfCurricularId = 8,
                    Content = "",
                },
                new Exercise
                {
                    Id = 83,
                    Title = "Графи",
                    SectionOfCurricularId = 9,
                    Content = "",
                },
                new Exercise
                {
                    Id = 84,
                    Title = "Дървета",
                    SectionOfCurricularId =9,
                    Content = "",
                },
                new Exercise
                {
                    Id = 85,
                    Title = "Обхождане на графи",
                    SectionOfCurricularId =9,
                    Content = "",
                },
                new Exercise
                {
                    Id = 86,
                    Title = "Най-къс път в граф",
                    SectionOfCurricularId = 9,
                    Content = "",
                },
                new Exercise
                {
                    Id = 87,
                    Title = "Хеш-таблица. Речник",
                    SectionOfCurricularId =9,
                    Content = "",
                },
                new Exercise
                {
                    Id = 88,
                    Title = "Работа по проект",
                    SectionOfCurricularId = 10,
                    Content = "",
                },
                new Exercise
                {
                    Id = 89,
                    Title = "Примерни проекти",
                    SectionOfCurricularId = 10,
                    Content = "",
                },
                new Exercise
                {
                    Id = 90,
                    Title = "Информационни системи и бази от данни",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 91,
                    Title = "Упражнение - преговор",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 92,
                    Title = "Сървър база от данни",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 93,
                    Title = "Таблици",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 94,
                    Title = "Въвеждане на данни",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 95,
                    Title = "Езикът SQL - преговор с допълнение",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 96,
                    Title = "Създаване н=и изпълнение на заявки",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 97,
                    Title = "Съхранени процедури",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 98,
                    Title = "Още за съхранените процедури",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 99,
                    Title = "Подържане на база от данни",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 100,
                    Title = "Клиентът Azure Data Studio",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 101,
                    Title = "Упражнение",
                    SectionOfCurricularId = 16,
                    Content = "",
                },
                new Exercise
                {
                    Id = 102,
                    Title = "Фази при разработване на проекти",
                    SectionOfCurricularId = 17,
                    Content = "",
                },
                new Exercise
                {
                    Id = 103,
                    Title = "Екип, документиране и защита на проекти",
                    SectionOfCurricularId = 17,
                    Content = "",
                },
                new Exercise
                {
                    Id = 104,
                    Title = "Езикът C# - преговор",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
                new Exercise
                {
                    Id = 105,
                    Title = "Свързване с базата данни",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
                new Exercise
                {
                    Id = 106,
                    Title = "Четене от база данни",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
                new Exercise
                {
                    Id = 107,
                    Title = "Приложение с графичен интерфейс",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
                new Exercise
                {
                    Id = 108,
                    Title = "Редактиране на данни",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
                new Exercise
                {
                    Id = 109,
                    Title = "Упражнение",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
                new Exercise
                {
                    Id = 110,
                    Title = "Интегриране с лента от менюта",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
                new Exercise
                {
                    Id = 111,
                    Title = "Още функционалност в ИС УЧИСЕ",
                    SectionOfCurricularId = 18,
                    Content = "",
                },
            });
        }
    }
}
