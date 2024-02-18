using PreparationForITExam.Core.Models.News;
using PreparationForITExam.Core.Models.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForITExam.Core.Models.Home
{
    public class HomeViewModel
    {
        public List<NewsViewModel> News { get; set; }
        public List<ReviewViewModel> Reviews { get; set; }
    }
}
