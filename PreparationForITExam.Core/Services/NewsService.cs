using Microsoft.EntityFrameworkCore;
using Microsoft.SharePoint.DesignTime.Activities;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Models.News;
using PreparationForITExam.Infrastructure.Data.Common;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Services
{
    public class NewsService : INewsService
    {
        private readonly IRepository repo;
        private readonly IMonUserService monUserService;

        public NewsService(IRepository _repo,
            IMonUserService _monUserService)
        {
            repo = _repo;
            monUserService = _monUserService;
        }

        public async Task AddNews(NewsFormViewModel model)
        {
            var news = new News();

            news.Title = model.Title;
            news.Description = model.Description;
            news.UsefulUrls = model.UsefulUrls;

            news.MonId = await monUserService.GetMonUserIdByUserId(model.UserId);

            await repo.AddAsync(news);
            await repo.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var news = await repo.GetByIdAsync<News>(id);

            news.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task Edit(NewsFormViewModel model)
        {
            var news = await repo.GetByIdAsync<News>(model.Id);

            news.Title = model.Title;
            news.Description = model.Description;
            news.UsefulUrls = model.UsefulUrls;

            await repo.SaveChangesAsync();
        }

        public async Task<List<NewsViewModel>> GetAllNews()
        {
            var news = await repo.AllReadonly<News>()
                .Where(n => n.IsActive == true)
                .Select(n => new NewsViewModel
                {
                    Id = n.Id,
                    Title = n.Title,
                    Description = n.Description,
                    PostedOn = n.PostedOn.ToString("yyyy-M-d"),
                    MonId = n.MonId,
                    MonName = n.Mon.User.FirstName + " " + n.Mon.User.LastName,
                    UsefulUrls = n.UsefulUrls,
                    UserProfileUrl = n.Mon.User.ProfilePictureUrl,
                    UserId = n.Mon.UserId
                })
                .OrderByDescending(n => n.Id)
                .ToListAsync();

            return news;
        }

        public async Task<NewsFormViewModel> GetNewsDetails(int id)
        {
            var model = await repo.AllReadonly<News>()
                .Where(n => n.Id == id && n.IsActive)
                .Select(news => new NewsFormViewModel()
                {
                    Id = id,
                    Title = news.Title,
                    Description = news.Description,
                    UsefulUrls = news.UsefulUrls,
                    UserId = news.Mon.UserId
                })
                .FirstOrDefaultAsync();

            return model;
        }
    }
}
