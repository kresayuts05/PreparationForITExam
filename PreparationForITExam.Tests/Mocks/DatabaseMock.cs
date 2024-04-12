using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Tests.Mocks
{
    public class DatabaseMock
    {
        public static PreparationForITExamDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<PreparationForITExamDbContext>()
                    .UseInMemoryDatabase("PreparationForITExamInMemoryDb"
                    + DateTime.Now.Ticks.ToString())
                    .Options;

                return new PreparationForITExamDbContext(dbContextOptions, false);
            }
        }
    }
}
