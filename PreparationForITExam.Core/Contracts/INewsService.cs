using PreparationForITExam.Core.Models.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Contracts
{
    public interface INewsService
    {
        Task<List<NewsViewModel>> GetAllNews();

        Task AddNews(NewsFormViewModel model);

        Task<NewsFormViewModel> GetNewsDetails(int id);

        Task Edit(NewsFormViewModel model);
        Task Delete(int id);
    }
}
