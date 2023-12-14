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
    public class LessonMonUserConfiguration : IEntityTypeConfiguration<LessonMonUser>
    {
        public void Configure(EntityTypeBuilder<LessonMonUser> builder)
        {
            builder.HasData(new List<LessonMonUser>
            {
                new LessonMonUser {
                    LessonId = 1,
                    MonUserId = 1,
                }

            });
        }
    }
}