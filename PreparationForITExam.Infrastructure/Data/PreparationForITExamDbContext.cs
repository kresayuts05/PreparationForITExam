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
        private bool seedDb;

        public PreparationForITExamDbContext(DbContextOptions<PreparationForITExamDbContext> options, bool seed = false)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<MonUser> MonUsers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<RequestLesson> RequestsLessons { get; set; }
        public DbSet<RequestExercise> RequestsExercises { get; set; }
        public DbSet<LessonMaterial> LessonMaterials { get; set; }
        public DbSet<ExerciseMaterial> ExerciseMaterials { get; set; }
        public DbSet<SectionOfCurricular> SectionsOfCurricular { get; set; }
        public DbSet<LessonMonUser> LessonMonUser { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Answer> Answers { get; set; }


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

            builder.Entity<Lesson>()
             .HasOne(e => e.Exercise)
             .WithOne()
             .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<LessonMonUser>()
               .HasKey(pk => new { pk.LessonId, pk.MonUserId });

                builder.ApplyConfiguration(new RoleConfiguration());
                builder.ApplyConfiguration(new UserConfiguration());
                builder.ApplyConfiguration(new MonUserConfiguration());
                builder.ApplyConfiguration(new ModuleOfCurricularConfiguration());
                builder.ApplyConfiguration(new SectionOfCurricularConfiguration());
                builder.ApplyConfiguration(new SchoolConfiguration());
                builder.ApplyConfiguration(new ExcersiseConfiguration());
                builder.ApplyConfiguration(new LessonConfiguration());
                builder.ApplyConfiguration(new LessonMonUserConfiguration());
                builder.ApplyConfiguration(new UserRoleConifiguration());
                builder.ApplyConfiguration(new TeacherConfiguration());
                builder.ApplyConfiguration(new StudentConfiguration());
                builder.ApplyConfiguration(new NewsConfiguration());
                builder.ApplyConfiguration(new PostConfiguration());
                builder.ApplyConfiguration(new ImageConfiguration());
            

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
