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
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(CreateImages());
        }

        private List<Image> CreateImages()
        {
            var images = new List<Image>();

            var image = new Image
            {
                Id = 1,
                PostId= 2,
                UrlPath = "https://res.cloudinary.com/dmv8nabul/image/upload/v1708546591/Screenshot_2024-02-21_204929_unv2sq.png"
            };

            images.Add(image);

             image = new Image
            {
                Id = 2,
                PostId = 2,
                UrlPath = "https://res.cloudinary.com/dmv8nabul/image/upload/v1708546591/Screenshot_2024-02-21_204941_pyjfvc.png"
            };

            images.Add(image);

             image = new Image
            {
                Id = 3,
                PostId = 2,
                UrlPath = "https://res.cloudinary.com/dmv8nabul/image/upload/v1708546591/Screenshot_2024-02-21_204834_g8nzay.png"
            };

            images.Add(image);

            image = new Image
            {
                Id = 4,
                PostId = 2,
                UrlPath = "https://res.cloudinary.com/dmv8nabul/image/upload/v1708546591/Screenshot_2024-02-21_204920_mpqsif.png"
            };

            images.Add(image);

            return images;
        }
    }
}

