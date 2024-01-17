using PreparationForITExam.Core.Models.SectionOfCurricular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ISectionOfCurricularService
    {
        Task<List<List<SectionOfCurricularViewModel>>> GetAllSectionsOfModule();
        Task<List<string>> GetTitleAndModuleOfSectionOfCurricularById(int id);
    }
}
