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
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasData(new List<Lesson>
            {
                new Lesson {
                    Id = 1,
                    Title = "Компютърът",
                    SectionOfCurricularId = 1,
                    Content = "",
                    ExerciseId = 1,
                },
            });
        }
    }
}
