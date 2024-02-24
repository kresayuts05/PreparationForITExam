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
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(CreatePosts());
        }

        private List<Post> CreatePosts()
        {
            var posts = new List<Post>();

            var post = new Post
            {
                Id = 2,
                Title= "Git игра",
                ShortDescription= "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description= "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 3,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);
            post = new Post
            {
                Id = 4,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 5,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 6,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 7,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 8,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 9,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 10,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 11,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 12,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 13,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 14,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 15,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 16,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 17,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 18,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "023bafc9-8b7e-4fbd-bb06-2b178fe8ae8b",
            };

            posts.Add(post);

            post = new Post
            {
                Id = 19,
                Title = "Git игра",
                ShortDescription = "Попаднах на страхотна игра, която ти помага да научиш Git",
                Description = "Имах затруднения да разбера Git технологията, но с помощта на тази игра бързо осъвършенствах функциите и начина на използване.",
                PostedOn = DateTime.Now,
                UsefulUrl = "https://learngitbranching.js.org/?locale=en_US",
                UserId = "9c7f55cd-f0ae-405e-b520-6e1ccc448fcc",
            };

            posts.Add(post);

            return posts;
        }
    }
}
