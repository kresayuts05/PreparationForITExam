using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Configurations
{
    public class MonUserConfiguration : IEntityTypeConfiguration<MonUser>
    {
        public void Configure(EntityTypeBuilder<MonUser> builder)
        {
            builder.HasData(CreateMonUsers());
        }

        private List<MonUser> CreateMonUsers()
        {
            var monUsers = new List<MonUser>();

            var monUser = new MonUser
            {
                Id = 1,
                UserId = "7decfb7d-d2df-40a2-a449-dcec04eb091a"
            };

            monUsers.Add(monUser);

            return monUsers;
        }
    }
}
