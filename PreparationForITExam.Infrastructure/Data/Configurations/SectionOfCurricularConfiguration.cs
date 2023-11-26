using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreparationForITExam.Infrastructure.Data.Entities;

namespace PreparationForITExam.Infrastructure.Data.Configurations
{
    public class SectionOfCurricularConfiguration : IEntityTypeConfiguration<SectionOfCurricular>
    {
        public void Configure(EntityTypeBuilder<SectionOfCurricular> builder)
        {
            builder.HasData(new List<SectionOfCurricular>
            {
                new SectionOfCurricular {
                    Id = 1,
                    Title = "Въведение",
                    ModuleOfCurricularId = 1
                },
                    new SectionOfCurricular {
                    Id = 2,
                    Title = "Програмиране на C#",
                    ModuleOfCurricularId = 1
                },
                    new SectionOfCurricular {
                    Id = 3,
                    Title = "Обектно-ориентиран подход",
                    ModuleOfCurricularId = 1
                },
                    new SectionOfCurricular {
                    Id = 4,
                    Title = "Графичен интергейс",
                    ModuleOfCurricularId = 1
                },
                    new SectionOfCurricular {
                    Id = 5,
                    Title = "Още за обектно-ориентирания подход",
                    ModuleOfCurricularId = 1
                },
                    new SectionOfCurricular {
                    Id = 6,
                    Title = "Въведение",
                    ModuleOfCurricularId = 2
                },
                    new SectionOfCurricular {
                    Id = 7,
                    Title = "Структури от данни",
                    ModuleOfCurricularId = 2
                },
                    new SectionOfCurricular {
                    Id = 8,
                    Title = "Абстрактни типове",
                    ModuleOfCurricularId = 2
                },
                    new SectionOfCurricular {
                    Id = 9,
                    Title = "Комбинаторни структури",
                    ModuleOfCurricularId = 2
                },
                    new SectionOfCurricular {
                    Id = 10,
                    Title = "Нелинейни и други АТ",
                    ModuleOfCurricularId = 2
                },
                    new SectionOfCurricular {
                    Id = 11,
                    Title = "Разработване на проект",
                    ModuleOfCurricularId = 2
                },
            });
        }
    }
}
