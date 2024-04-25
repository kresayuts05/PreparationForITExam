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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(CreateNews());
        }

        private List<Question> CreateNews()
        {
            var allQuestions = new List<Question>();

            var question = new Question
            {
                Id = 1,
                Description = "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:" ,
                RightAnswer = "8 -> 0",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714065745/Screenshot_2024-04-25_202139_dtmv9i.png",
                CategoryId = 4,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 2,
                Description = "Ако знаете, че ASCII кодът на буквата 'a' е 97, кой от низовте ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:",
                RightAnswer = "bnbajoh",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714066118/Screenshot_2024-04-25_202822_wyk7lf.png",
                CategoryId = 6,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 3,
                Description = "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:",
                RightAnswer = "9",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714066826/Screenshot_2024-04-25_203444_ygxcbt.png",
                CategoryId = 8,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 4,
                Description = "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:",
                RightAnswer = "4",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714066882/Screenshot_2024-04-25_204000_yv4gms.png",
                CategoryId = 11,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 5,
                Description = "Каква е причината за грешката в следния програмен фрагмент?",
                RightAnswer = "Не може да се променя списакът по време на итерация на foreach цикъла;",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714067374/Screenshot_2024-04-25_204915_wme5tz.png",
                CategoryId = 2,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 6,
                Description = "Коя от следните стойности може да се присвои на променлива от тип ushort?",
                RightAnswer = "'5'",
                CategoryId = 1,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 7,
                Description = "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:",
                RightAnswer = "4 5 5.74",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714067739/Screenshot_2024-04-25_205521_nfioem.png",
                CategoryId = 3,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);


            question = new Question
            {
                Id = 8,
                Description = "Какъв тип данни връща методът Next() на класа System.Random при генериране на случайно число?",
                RightAnswer = "int",
                CategoryId = 5,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 9,
                Description = "Трябва да създадете приложение с графичен потребителски интерфейс, в което човек трябва да попълни информация. Необходимо е да определи какви занимания са му любими, като избере колкото желае от 5 посочени възможност. С какви елементи на потребителския интерфейс да се визуализират заниманията?",
                RightAnswer = "полета  за отметка (check boxes)",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714067739/Screenshot_2024-04-25_205521_nfioem.png",
                CategoryId = 20,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 10,
                Description = "Какъв резултат ще се изведе на стандартния изход след изпълнение на следния програмен фрагмент:",
                RightAnswer = "3",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714068288/Screenshot_2024-04-25_210424_yiywpw.png",
                CategoryId = 20,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 11,
                Description = "В проект е създаден клас със статичен метод:",
                RightAnswer = "Console.WriteLine(Sequence.Fibonacci(7));",
                Image = "https://res.cloudinary.com/dmv8nabul/image/upload/v1714068480/Screenshot_2024-04-25_210746_lm3lcr.png",
                CategoryId = 17,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 12,
                Description = "На кой етап от жизнения цикъл на информационна система се избират технологиите, които ще се използват и стандарта за писане на код?",
                RightAnswer = "анализ и дефиниция",
                CategoryId = 25,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 13,
                Description = "Релационна база от данни за туристическа агенция съдържа няколко таблици. Едната от таблиците дава информация за клиентите на агенцията, а друга за нейните дестинации на пътувания. За да се отрази правилно дейността на агенцията, тези две таблици трябва:",
                RightAnswer = "да са свързани с връзка „много към много“ чрез допълнителна таблица;",
                CategoryId = 21,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            question = new Question
            {
                Id = 14,
                Description = "Каква е основната разлика между ArrayList и обикновенния масив (array) в C#?",
                RightAnswer = "ArrayList автоматично разширява размера си при добавяне на нови елементи, докато обикновният масив има фиксиран размер",
                CategoryId = 10,
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            allQuestions.Add(question);

            return allQuestions;
        }
    }
}
