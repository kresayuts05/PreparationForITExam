using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PreparationForITExam.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "789061a9-edaa-4a00-9e09-add6a20c8288",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                FirstName = "Креса",
                LastName = "Цветкова",
                City = "Казанлък",
                PhoneNumber = "0886121260",
                RoleName = "Administrator",
                AboutMe = "Разработвам това приложение, за да участвам в олимпиада по информационни технологии. Темата си избрах след първата матура по Информатика. Моите учители и приятели, които се явиха на това ДЗИ, имаха проблем с намирането на полезни материали и информация за самата матура. Това приложение се надявам, че би олеснило подготовката, защото хора с еднакви интереси и задачи могат да комуникират и обменят знания. Също така, учители могат да предадат знанията си на ученици, които наистина имат желание да се научат и полагат усилия.",
                ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334401/kresa_bkbaoa.jpg"
            };

            user.PasswordHash = hasher.HashPassword(user, "111111");

            users.Add(user);

             user = new User()
            {
                Id = "7decfb7d-d2df-40a2-a449-dcec04eb091a",
                Email = "monuser@gmail.com",
                NormalizedEmail = "MONUSER@GMAIL.COM",
                UserName = "monuser@gmail.com",
                NormalizedUserName = "MONUSER@GMAIL.COM",
                FirstName = "Валентин",
                LastName = "Терзиев",
                City = "Кърджали",
                PhoneNumber = "0886121261",
                RoleName = "MonUser",
                AboutMe = "Работя в МОН от 5 години. Преподавам по Информатика в частна школа. Програмирането е моята страст. Обичам фо повече от приятелката ми.",
                ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334408/valentin_u5en92.jpg"
             };

            user.PasswordHash = hasher.HashPassword(user, "111111");

            users.Add(user);

            user = new User()
            {
                Id = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
                Email = "student@gmail.com",
                NormalizedEmail = "STUDENT@GMAIL.COM",
                UserName = "student@gmail.com",
                NormalizedUserName = "STUDENT@GMAIL.COM",
                FirstName = "Никол",
                LastName = "Груева",
                City = "Миделбург",
                PhoneNumber = "0886121262",
                RoleName = "Student",
                AboutMe = "Занимавам се с програмиране от 3 години. Интересувам се от кибер сигурност, а именно и това искам да уча след като завърша.",
                ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334404/nikol_prlrcl.jpg"
            };

            user.PasswordHash = hasher.HashPassword(user, "111111");

            users.Add(user);

            user = new User()
            {
                Id = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
                Email = "teacher@gmail.com",
                NormalizedEmail = "TEACHER@GMAIL.COM",
                UserName = "teacher@gmail.com",
                NormalizedUserName = "TEACHER@GMAIL.COM",
                FirstName = "Ивета",
                LastName = "Найденова",
                City = "София",
                PhoneNumber = "0886121262",
                RoleName = "Teacher",
                AboutMe = "Учителка съм от 12 години. Избрах тази професия, защото работата с деца е моята страст. В работата си опитвам да предам знанията си колкото повече мога. Мой интерес е работата с ASP.NET.",
                ProfilePictureUrl = "https://res.cloudinary.com/dmv8nabul/image/upload/v1707334395/iveta_rknyn3.jpg"
            };

            user.PasswordHash = hasher.HashPassword(user, "111111");

            users.Add(user);

            return users;
        }
    }
}

