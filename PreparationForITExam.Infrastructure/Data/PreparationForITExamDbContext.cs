using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Infrastructure.Data.Configurations;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static PreparationForITExam.Infrastructure.Data.Constants.ModelConstraints.UserConstraints;

namespace PreparationForITExam.Infrastructure.Data
{
    public class PreparationForITExamDbContext : IdentityDbContext<User>
    {

        public PreparationForITExamDbContext(DbContextOptions<PreparationForITExamDbContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<MonUser> MonUsers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsComment> NewsComments { get; set; }
        public DbSet<RequestLesson> RequestsLessons { get; set; }
        public DbSet<RequestExercise> RequestsExercises { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<SectionOfCurricular> SectionsOfCurricular { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
               .Property(u => u.UserName)
               .HasMaxLength(UserNameMaxLength)
               .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(EmailMaxLength)
                .IsRequired();

            builder.Entity<Exercise>()
                .HasOne(e => e.Lesson)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new ModuleOfCurricularConfiguration());
            builder.ApplyConfiguration(new SectionOfCurricularConfiguration());
            builder.ApplyConfiguration(new SchoolConfiguration());

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
