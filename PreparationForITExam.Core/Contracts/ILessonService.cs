﻿using PreparationForITExam.Core.Models.Lesson;
using PreparationForITExam.Core.Models.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ILessonService
    {
        Task<List<LessonModel>> AllLessonsBySectionOfCurricularId(int sectionId);
    }
}