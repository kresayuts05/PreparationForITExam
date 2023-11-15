using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new List<IdentityRole>
            {
                new IdentityRole {
                Id ="0f761db2-ab55-416c-83b9-70abded3d908" ,
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
              },
              new IdentityRole {
                Id ="e66d730b-bcf1-41b5-b7e0-3e66056e61d9" ,
                Name = "Student",
                NormalizedName = "STUDENT"
              },
              new IdentityRole {
                Id = "71281cf3-9730-4d7e-acbb-213edee8291c",
                Name = "Teacher",
                NormalizedName = "TEACHER"
              },
               new IdentityRole {
                Id = "fe750b82-6fe9-472c-bdc5-61f5433d429e",
                Name = "MonUser",
                NormalizedName = "MONUSER"
              },
            });
        }
    }
}
