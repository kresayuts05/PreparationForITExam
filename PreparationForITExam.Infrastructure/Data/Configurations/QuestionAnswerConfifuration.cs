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
    public class QuestionAnswerConfifuration : IEntityTypeConfiguration<QuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<QuestionAnswer> builder)
        {
            builder.HasData(CreateQuestionAnswer());
        }

        private List<QuestionAnswer> CreateQuestionAnswer()
        {
            var allQuestionAnswers = new List<QuestionAnswer>();

            var answer = new QuestionAnswer
            {
                Id = 1,
                Value = "7 -> 2",
                QuestionId = 1,
            };

            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 2,
                Value = "7 -> 0",
                QuestionId = 1,
            };

            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 3,
                Value = "8 -> 0",
                QuestionId = 1,
            };

            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 4,
                Value = "6 -> 1",
                QuestionId = 1,
            };

            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 5,
                Value = "bnbajoh",
                QuestionId = 2,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 6,
                Value = "cocbkpi",
                QuestionId = 2,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 7,
                Value = "bnbajog",
                QuestionId = 2,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 8,
                Value = "cocblpi",
                QuestionId = 2,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 9,
                Value = "16",
                QuestionId = 3,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 10,
                Value = "31",
                QuestionId = 3,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 11,
                Value = "12",
                QuestionId = 3,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 12,
                Value = "9",
                QuestionId = 3,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 13,
                Value = "1",
                QuestionId = 4,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 14,
                Value = "2",
                QuestionId = 4,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 56,
                Value = "3",
                QuestionId = 4,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 15,
                Value = "4",
                QuestionId = 4,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 16,
                Value = "Не може към списък с елементи от тип int да добавяме елементи от тип char;",
                QuestionId = 5,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 17,
                Value = "Не може с цикъл foreach да се обхождат елементи на списък от тип char;",
                QuestionId = 5,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 18,
                Value = "Не може да се променя списакът по време на итерация на foreach цикъла;",
                QuestionId = 5,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 19,
                Value = "Не може да изтриваме елементи от списък;",
                QuestionId = 5,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 20,
                Value = "-567",
                QuestionId = 6,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 21,
                Value = "0.8",
                QuestionId = 6,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 22,
                Value = "67500",
                QuestionId = 6,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 23,
                Value = "'5'",
                QuestionId = 6,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 24,
                Value = "5 0 3.74",
                QuestionId = 7,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 25,
                Value = "4 5 5.74",
                QuestionId = 7,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 26,
                Value = "4 5 5.75",
                QuestionId = 7,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 27,
                Value = "4 0 3.75",
                QuestionId = 7,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 28,
                Value = "int",
                QuestionId = 8,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 29,
                Value = "double",
                QuestionId = 8,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 30,
                Value = "float",
                QuestionId = 8,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 31,
                Value = "string",
                QuestionId = 8,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 32,
                Value = "радио бутони (radio buttons)",
                QuestionId = 9,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 33,
                Value = "полета  за отметка (check boxes)",
                QuestionId = 9,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 34,
                Value = "списъчно поле (list box)",
                QuestionId = 9,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 35,
                Value = "падащ списък (combo box)",
                QuestionId = 9,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 36,
                Value = "0",
                QuestionId = 10,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 37,
                Value = "1",
                QuestionId = 10,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 38,
                Value = "3",
                QuestionId = 10,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 39,
                Value = "7",
                QuestionId = 10,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 40,
                Value = "Sequence sequence = new Sequence();" + Environment.NewLine + "Console.WriteLine(sequence.Fibonacci(7));",
                QuestionId = 11,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 41,
                Value = "Console.WriteLine(Sequence.Fibonacci(7));",
                QuestionId = 11,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 42,
                Value = "Console.WriteLine(Fibonacci(7));",
                QuestionId = 11,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 43,
                Value = "Console.WriteLine(Sequence(7));",
                QuestionId = 11,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 44,
                Value = "анализ и дефиниция",
                QuestionId = 12,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 45,
                Value = "проектиране",
                QuestionId = 12,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 46,
                Value = "разработка",
                QuestionId = 12,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 47,
                Value = "тестване",
                QuestionId = 12,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 48,
                Value = "да са свързани с връзка „едно към едно“;",
                QuestionId = 13,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 49,
                Value = "да са свързани с връзка „едно към много“;",
                QuestionId = 13,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 50,
                Value = "да са свързани с връзка „много към много“ чрез допълнителна таблица;",
                QuestionId = 13,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 51,
                Value = "да не бъдат свързвани.",
                QuestionId = 13,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 52,
                Value = "ArrayList може да съдържа елементи само от типове string и int, докато обикновният масив е ограничен до елементи от един и същи тип",
                QuestionId = 14,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 53,
                Value = "ArrayList поддържа генеричност, докато обикновният масив не",
                QuestionId = 14,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 54,
                Value = "ArrayList е част от пространството от имена System.Collections, докато обикновният масив е част от пространството от имена System.Collections.Generic",
                QuestionId = 14,
            };
            allQuestionAnswers.Add(answer);

            answer = new QuestionAnswer
            {
                Id = 55,
                Value = "ArrayList автоматично разширява размера си при добавяне на нови елементи, докато обикновният масив има фиксиран размер",
                QuestionId = 14,
            };
            allQuestionAnswers.Add(answer);

            return allQuestionAnswers;
        }
    }
}
