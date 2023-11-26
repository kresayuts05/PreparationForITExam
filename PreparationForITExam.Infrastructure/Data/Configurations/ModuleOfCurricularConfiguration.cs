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
    public class ModuleOfCurricularConfiguration : IEntityTypeConfiguration<ModuleOfCurricular>
    {
        public void Configure(EntityTypeBuilder<ModuleOfCurricular> builder)
        {
            builder.HasData(new List<ModuleOfCurricular>
            {
                new ModuleOfCurricular {
                    Id = 1,
                    Title = "Обектно-ориентирано проектиране и програмиране"
                },
                new ModuleOfCurricular {
                    Id = 2,
                    Title = "Структури от данни и алгоритми"
                },
                new ModuleOfCurricular {
                    Id = 3,
                    Title = "Релационен модел на бази от данни"
                },
                new ModuleOfCurricular {
                    Id = 4,
                    Title = "Програмиране на информационни системи"
                },
            });
        }
    }
}
