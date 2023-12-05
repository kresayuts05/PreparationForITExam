using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Constants
{
    public static class ModelConstraints
    {
        public static class UserConstraints
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 2;

            public const int CityMaxLength = 169;
            public const int CityMinLength = 1;

            public const int EmailMaxLength = 60;
            public const int EmailMinLength = 10;

            public const int UserNameMaxLength = 50;
            public const int UserNameMinLength = 4;
        }

        public static class TeacherConstraints
        {
            public const int ExperienceMaxValue = 60;
            public const int ExperienceMinValue = 0;

            public const int SubjectMaxLength = 50;
            public const int SubjectMinLength = 2;

            public const int UniversityMaxLength = 60;
            public const int UniversityMinLength = 1;

            public const int AboutMeMaxLength = 300;
            public const int AboutMeMinLength = 10;
        }

        public static class StudentConstraints
        {
            public const int SpecialtyMaxLength = 40;
            public const int SpecialtyMinLength = 2;

            public const int GradeMaxValue = 12;
            public const int GradeMinValue = 8;

            public const int AboutMeMaxLength = 300;
            public const int AboutMeMinLength = 10;
        }
        public static class SchoolConstraints
        {
            public const int NameMaxLength = 250;
            public const int NameMinLength = 2;

            public const int CitySchoolMaxLength = 169;
            public const int CitySchoolMinLength = 1;
        }

        public static class CommentConstraints
        {
            public const int ContentMaxLength = 400;
            public const int ContentMinLength = 4;
        }

        public static class PostConstraints
        {
            public const int TitleMaxLength = 60;
            public const int TitleMinLength = 2;

            public const int ShortDescriptionMaxLength = 100;
            public const int ShortDescriptionMinLength = 1; 
            
            public const int DescriptionMaxLength = 3000;
            public const int DescriptionMinLength = 1;
        }

        public static class NewsConstraints
        {
            public const int TitleMaxLength = 60;
            public const int TitleMinLength = 2;

            public const int DescriptionMaxLength = 3000;
            public const int DescriptionMinLength = 1;
        }

        public static class MaterialConstraints
        {
            public const int NameMaxLength = 50;
            public const int NameMinLength = 2;
        }

        public static class LessonConstraints
        {
            public const int TitleMaxLength = 60;
            public const int TitleMinLength = 2;

            public const int GroupMaxLength = 50;
            public const int GroupMinLength = 2;

            public const int ContentMaxLength = 4000;
            public const int ContentMinLength = 2;
        }

        public static class RequestConstraints
        {
            public const int ChangedContentMaxLength = 4000;
            public const int ChangedContentMinLength = 10;

            public const int SuggestionMaxLength = 4000;
            public const int SuggestionMinLength = 10;
        }

        public static class ExerciseConstraints
        {
            public const int TitleMaxLength = 60;
            public const int TitleMinLength = 2;

            public const int ContentMaxLength = 4000;
            public const int ContentMinLength = 2;
        }

        public static class SectionOfCurricularConstraints
        {
            public const int TitleMaxLength = 100;
            public const int TitleMinLength = 2;
        }

        public static class ModuleOfCurricularConstraints
        {
            public const int TitleMaxLength = 100;
            public const int TitleMinLength = 2;
        }

        public static class QuestionConstraints
        {
            public const int QuestionMaxLength = 250;
            public const int QuestionMinLength = 3;

            public const int CorrectAnswerMaxLength = 150;
            public const int CorrectAnswerMinLength = 2;

            public const int WrongAnswerMaxLength = 500;
            public const int WrongAnswerMinLength = 2; 
            
            public const int PointsMaxValue = 500;
            public const int PointsMinValue = 2;
        }
    }
}
