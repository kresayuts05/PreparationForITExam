using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class ModuleOfCurricularService : IModuleOfCurricularService
    {

        private readonly IRepository repo;

        public ModuleOfCurricularService(IRepository _repo)
        {
            repo = _repo;
        }


        public async Task<string> GetTitleByModuleOCurricularId(int id)
        {
            var module = await repo.GetByIdAsync<ModuleOfCurricular>(id);

            return module.Title;
        }
    }
}
