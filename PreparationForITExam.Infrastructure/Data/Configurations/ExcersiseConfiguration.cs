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
                new Exercise {
                    Id = 1,
                    Title = "Компютърът",
                    Content = "",
                },
                new Exercise {
                    Id = 2,
                    Title = "Езици за програмиране",
                 Content = "",
                },
                new Exercise
                {
                    Id = 3,
                    Title = "Инструменти и IDE",
                 Content = "",
                },
                new Exercise
                {
                    Id = 4,
                    Title = "IDE Visual Studio",
                 Content = "",
                },
                new Exercise
                {
                    Id = 5,
                    Title = "Елементи на програмата",
                Content = "",
                },
                 new Exercise
                 {
                     Id = 6,
                     Title = "Основни типове операции и оператори",
                  Content = "",
                  },
                  new Exercise
                  {
                      Id = 7,
                      Title = "Изчислителни процеси. Линейни процеси",
                    Content = "",
                    },
                   new Exercise
                   {
                       Id = 8,
                       Title = "Линейни изчислителни процеси. Упражнение",
                       Content = "",
                      },
                    new Exercise
                    {
                        Id = 9,
                        Title = "Сравнения и логически операции",
                     Content = "",
                    },
                    new Exercise
                    {
                        Id = 10,
                        Title = "Разклонени изчислителни процеси",
                     Content = "",
                     },
                    new Exercise
                    {
                        Id = 11,
                        Title = "Циклични изчислителни процеси",
                     Content = "",
                     },
                    new Exercise
                    {
                        Id = 12,
                        Title = "Оператори за цикъл с условие",
                     Content = "",
                     },
                    new Exercise
                    {
                        Id = 13,
                        Title = "Оператори за цикъл. Упражнение",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 14,
                        Title = "Обекти и класове от обекти",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 15,
                        Title = "Класове",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 16,
                        Title = "Клас с контролирани атрибути",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 17,
                        Title = "Функции и методи",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 18,
                        Title = "Конструктори",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 19,
                        Title = "Предаване на аргументи",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 20,
                        Title = "Упражнение",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 21,
                        Title = "Елементи на графичние интерфейс",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 22,
                        Title = "Графични компоненти",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 23,
                        Title = "Упражнение",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 24,
                        Title = "Упражнение",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 25,
                        Title = "Агрегатни типове",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 26,
                        Title = "Файлове",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 27,
                        Title = "Четене на обекти от файл",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 28,
                        Title = "Документиране на клас. Сериализация",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 29,
                        Title = "Капсулиране. Статични атрибути и методи",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 30,
                        Title = "Йерархия от класове",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 31,
                        Title = "Полиморфизъм",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 32,
                        Title = "Абстракция класове. Интерфейси",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 33,
                        Title = "Изключения",
                        Content = "",
                     },
                    new Exercise
                    {
                        Id = 34,
                        Title = "Информация и данни",
                         Content = "",
                     },
                    new Exercise
                    {
                        Id = 35,
                        Title = "Информационни системи и процеси",
                         Content = "",
                     },
                     new Exercise
                  {
                    Id = 36,
                    Title = "Файлов подход и подход с бази от данни",
                     Content = "",
                  },
                  new Exercise
                {
                    Id = 37,
                    Title = "Упражнение",
                    Content = "",
                  },
                  new Exercise
                {
                    Id = 38,
                    Title = "Множества и релации",
                    Content = "",
                },
                new Exercise
                {
                    Id = 39,
                    Title = "Релационна база от данни",
                    Content = "",
                },
                new Exercise
                {
                    Id = 40,
                    Title = "Операции с релации",
                 Content = "",
                },
                new Exercise
                {
                    Id = 41,
                    Title = "Типове данни с релации",
                Content = "",
                },
                new Exercise
                {
                    Id = 42,
                    Title = "Типове данни. Ключове",
                 Content = "",
                },
                new Exercise
                {
                    Id = 43,
                    Title = "Нормализация",
                 Content = "",
                },
                new Exercise
                {
                    Id = 44,
                    Title = "Модел обект-взаимодействие",
                 Content = "",
                },
                new Exercise
                {
                    Id = 45,
                    Title = "Нива на абстракция. Аномалии",
                 Content = "",
                },
                new Exercise
                {
                    Id = 46,
                    Title = "Проектиране на БД. Упражнение",
                 Content = "",
                },
                new Exercise
                {
                    Id = 47,
                    Title = "Програмата MS Access",
                 Content = "",
                },
                  new Exercise
                  {
                      Id = 48,
                      Title = "Езикът SQL. Заявки",
                     Content = "",
                  },
                    new Exercise
                    {
                        Id = 49,
                        Title = "Заявка SELECT",
                         Content = "",
                       },
                    new Exercise
                    {
                        Id = 50,
                        Title = "Клаузите ORDER BY и GROUP BY",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 51,
                        Title = "Екранни форми. Контрол на данните",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 52,
                        Title = "Търсене на данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 53,
                        Title = "Създаване и редактиране на таблици със SQL",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 54,
                        Title = "Упражнение",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 55,
                        Title = "Отчети",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 56,
                        Title = "Връзки между таблиците. Съединиение",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 57,
                        Title = "Влагане на заявки",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 58,
                        Title = "Упражнение",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 59,
                        Title = "Интегриране на БД в MS Access",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 60,
                        Title = "Интегриране на БД със C#",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 61,
                        Title = "Упражнение",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 62,
                        Title = "Алгоритми",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 63,
                        Title = "UML-диаграми упражнение",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 64,
                        Title = "Сложност на алгоритми",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 65,
                        Title = "Обектно-ориентирано програмиране - преговор",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 66,
                        Title = "Реализация на алгоритми чрез методи",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 67,
                        Title = "Рекурсия и интеграция",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 68,
                        Title = "Сложност на програми",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 69,
                        Title = "Едномерен масив - преговор",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 70,
                        Title = "Сортиране на масив",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 71,
                        Title = "Работа със сортирани масиви",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 72,
                        Title = "Сортиране на масив",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 73,
                        Title = "Работа със сортирани масиви",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 74,
                        Title = "Низове",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 75,
                        Title = "Масиви от знаци",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 76,
                        Title = "Многомерни масиви",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 77,
                        Title = "Основни понятия",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 78,
                        Title = "Вградени АТ в C#",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 79,
                        Title = "Списъци",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 80,
                        Title = "Опашки",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 81,
                        Title = "Стек",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 82,
                        Title = "Упражнение",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 83,
                        Title = "Графи",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 84,
                        Title = "Дървета",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 85,
                        Title = "Обхождане на графи",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 86,
                        Title = "Най-къс път в граф",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 87,
                        Title = "Хеш-таблица. Речник",
                        Content = "",
                    },
                    new Exercise
                    {
                        Id = 88,
                        Title = "Работа по проект",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 89,
                        Title = "Примерни проекти",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 90,
                        Title = "Информационни системи и бази от данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 91,
                        Title = "Упражнение - преговор",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 92,
                        Title = "Сървър база от данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 93,
                        Title = "Таблици",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 94,
                        Title = "Въвеждане на данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 95,
                        Title = "Езикът SQL - преговор с допълнение",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 96,
                        Title = "Създаване н=и изпълнение на заявки",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 97,
                        Title = "Съхранени процедури",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 98,
                        Title = "Още за съхранените процедури",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 99,
                        Title = "Подържане на база от данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 100,
                        Title = "Клиентът Azure Data Studio",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 101,
                        Title = "Упражнение",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 102,
                        Title = "Фази при разработване на проекти",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 103,
                        Title = "Екип, документиране и защита на проекти",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 104,
                        Title = "Езикът C# - преговор",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 105,
                        Title = "Свързване с базата данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 106,
                        Title = "Четене от база данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 107,
                        Title = "Приложение с графичен интерфейс",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 108,
                        Title = "Редактиране на данни",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 109,
                        Title = "Упражнение",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 110,
                        Title = "Интегриране с лента от менюта",
                         Content = "",
                    },
                    new Exercise
                    {
                        Id = 111,
                        Title = "Още функционалност в ИС УЧИСЕ",
                         Content = "",
                    },
            });
        }
    }
}
