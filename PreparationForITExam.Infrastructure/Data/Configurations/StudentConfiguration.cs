using Microsoft.AspNetCore.Identity;
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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(CreateStudents());
        }

        private List<Student> CreateStudents()
        {
            var students = new List<Student>();

            var student = new Student
            {
                Id= 1,
                SchoolId = 152,
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b"
            };

            students.Add(student);            

            return students;
        }
    }
}
