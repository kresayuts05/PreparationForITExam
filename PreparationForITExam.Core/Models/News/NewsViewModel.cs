using PreparationForITExam.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.News
{
    public class NewsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int SeenByPeople { get; set; }

        public string PostedOn { get; set; }

        public bool IsActive { get; set; }

        public int MonId { get; set; }

        public string UserId { get; set; }

        public string MonName { get; set; }

        public string UserProfileUrl { get; set; }

        public string? UsefulUrls { get; set; }

    }
}
