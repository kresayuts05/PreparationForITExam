using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface IStudentService
    {
        Task Create(string userId, int schoolId);
    }
}
