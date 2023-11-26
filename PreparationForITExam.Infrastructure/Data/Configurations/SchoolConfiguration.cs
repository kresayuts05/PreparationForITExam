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
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasData(new List<School>
            {
                new School {
                    Id = 1,
                    Name = "Профилираната гимназия за изобразителни изкуства „Професор Николай Райнов",
                    City = "София"
                },
            });
        }
    }
}
