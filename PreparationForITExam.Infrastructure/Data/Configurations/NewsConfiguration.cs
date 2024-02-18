using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Infrastructure.Data.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasData(CreateNews());
        }

        private List<News> CreateNews()
        {
            var allNews = new List<News>();

            var news = new News
            {
                Id = 1,
                Title = "ДЗИ 23 май 2023г",
                Description = "Изпитните материали от днешният изпит вече са налични онлайн на сайта на МОН.",
                PostedOn = DateTime.Now,
                MonId= 1,
                UsefulUrls= "https://web.mon.bg/bg/101234",
            };

            allNews.Add(news);

            news = new News
            {
                Id = 2,
                Title = "ДЗИ 25 август 2023г",
                Description = "Изпитните материали от днешният изпит вече са налични онлайн на сайта на МОН.",
                PostedOn = DateTime.Now,
                MonId = 1,
                UsefulUrls = "https://web.mon.bg/bg/101234",
            };

            allNews.Add(news);

            news = new News
            {
                Id = 3,
                Title = "Изпитни дати за 2023/2024 г.",
                Description = "Датите за тазгодишната изпитна кампания са 20 май 2024г.",
                PostedOn = DateTime.Now,
                MonId = 1,
                UsefulUrls = "https://danybon.com/wp-content/uploads/2023/09/zap2050_NVO_01092023.pdf",
            };

            allNews.Add(news);

            return allNews;
        }
    }
}
