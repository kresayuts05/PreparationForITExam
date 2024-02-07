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
                Email = "kresa@gmail.com",
                NormalizedEmail = "KRESA@GMAIL.COM",
                UserName = "kresa@gmail.com",
                NormalizedUserName = "KRESA@GMAIL.COM",
                FirstName = "Креса",
                LastName = "Цветкова",
                City = "Казанлък",
                PhoneNumber = "0886121260",
                RoleName = "Administrator"
            };

            user.PasswordHash = hasher.HashPassword(user, "111111");

            users.Add(user);

            return users;
        }
    }
}

