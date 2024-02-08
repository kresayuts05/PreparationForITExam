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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(CreateStudents());
        }

        private List<Teacher> CreateStudents()
        {
            var teachers = new List<Teacher>();

            var teacher = new Teacher
            {
               Id = 1,
               SchoolId = 289,
               Experience = 12, 
               Subject = "Информатика",
               UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc"
            };

            teachers.Add(teacher);

            return teachers;
        }
    }
}
