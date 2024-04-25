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
    public class QuestionCategoryConfiguration : IEntityTypeConfiguration<QuestionCategory>
    {
        public void Configure(EntityTypeBuilder<QuestionCategory> builder)
        {
            builder.HasData(new List<QuestionCategory>
            {
                new QuestionCategory {
                    Id = 1,
                    Name = "Синтаксис на оператори и изрази"
                },
                    new QuestionCategory {
                    Id = 2,
                    Name = "Грешки в синтаксиса и в логиката"
                },
                    new QuestionCategory {
                    Id = 3,
                    Name = "Пресмятания на аритметични и логически изрази"
                },
                    new QuestionCategory {
                    Id = 4,
                    Name = "Конструкции за разклонение и повторение"
                },
                     new QuestionCategory {
                    Id = 5,
                    Name = "Използване на библиотеки от класове"
                },
                      new QuestionCategory {
                    Id = 6,
                    Name = "Използване на низове"
                },
                       new QuestionCategory {
                    Id = 7,
                    Name = "Използване на линейни абстрактни типове данни"
                },
                        new QuestionCategory {
                    Id = 8,
                    Name = "Линейни структури от данни"
                },
                         new QuestionCategory {
                    Id = 9,
                    Name = "Търсене в линейни структури от данни"
                },
                          new QuestionCategory {
                    Id = 10,
                    Name = "Използване на библиотеки с колекции"
                },
                           new QuestionCategory {
                    Id = 11,
                    Name = "Рекурсивни методи"
                },
                            new QuestionCategory {
                    Id = 12,
                    Name = "Използване на текстови файлове"
                },
                             new QuestionCategory {
                    Id = 13,
                    Name = "Използване на двумерни масиви"
                },
                              new QuestionCategory {
                    Id = 14,
                    Name = "Връзки между класове „има“ и „е“"
                },
                               new QuestionCategory {
                    Id = 15,
                    Name = "Композиция и наследственост при класове"
                },
                               new QuestionCategory {
                    Id = 16,
                    Name = "Капсулация в ООП"
                },
                               new QuestionCategory {
                    Id = 17,
                    Name = "Статични данни и методи"
                },
                               new QuestionCategory {
                    Id = 18,
                    Name = "UML диаграма на клас"
                },
                               new QuestionCategory {
                    Id = 19,
                    Name = "Създаване и обработване на изключения"
                },
                               new QuestionCategory {
                    Id = 20,
                    Name = "Проектиране на графичен интерфейс на програма"
                },
                               new QuestionCategory {
                    Id = 21,
                    Name = "Връзки между таблици в БД"
                },
                               new QuestionCategory {
                    Id = 22,
                    Name = "Създаване на заявки с езика SQL"
                },
                               new QuestionCategory {
                    Id = 23,
                    Name = "Прилагане на заявки, написани на езика SQL"
                },
                               new QuestionCategory {
                    Id = 24,
                    Name = "Създаване на БД по диаграма"
                },
                               new QuestionCategory {
                    Id = 25,
                    Name = "Етапи от жизнения цикъл на информационна система"

                },
            });
        }
    }
}
