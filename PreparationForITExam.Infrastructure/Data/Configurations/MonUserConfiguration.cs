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
            builder.HasData(new List<MonUser>
            {
                 new MonUser {
                    Id = 1,
                    UserId = "789061a9-edaa-4a00-9e09-add6a20c8288",
                 },
            });
        }
    }
}
