using PreparationForITExam.Core.Models.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface ISchoolService
    {
        Task<int> GetSchoolByNameAndCity(string schoolName, string city);

        Task<List<SchoolModel>> AllSchools();

        Task<Dictionary<string, List<SchoolModel>>> AllSchoolsWithCitiesAsDitionary();

        Task<string> GetSchoolNameByUserId(string id);
    }
}
