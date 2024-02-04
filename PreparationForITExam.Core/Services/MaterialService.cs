using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Infrastructure.Data.Entities;
using Syncfusion.Presentation;
using Syncfusion.PresentationRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreparationForITExam.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Office.Server.Search.Query;
using Syncfusion.Pdf;
using SkiaSharp;
using static Microsoft.Office.Server.Search.Internal.UI.CrawlLogPageBase;

namespace PreparationForITExam.Core.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly Cloudinary cloudinary;
        private readonly IRepository repo;

        public MaterialService(
            Cloudinary cloudinary,
            IRepository _repo)
        {
            this.cloudinary = cloudinary;
            repo = _repo;
        }

        public async Task ConvertPresentationToPdf(IFormFile file, string userId, int lessonId)
        {
            Material material = new Material();

            using (var input = file.OpenReadStream())
            {
                using(IPresentation pptxDoc = Presentation.Open(input))
                {
                    PdfDocument pdfDcument = PresentationToPdfConverter.Convert(pptxDoc);
                    MemoryStream ms = new MemoryStream();
                    pdfDcument.Save(ms);
                    ms.Position = 0;

                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription("lesson.pdf", ms)
                    };

                    var result = await this.cloudinary.UploadAsync(uploadParams);

                    if (result.Error != null)
                    {
                        throw new InvalidOperationException(result.Error.Message);
                    }

                    material = new Material
                    {
                        UrlPath = result.Url.ToString(),
                        LessonId = lessonId,
                        UserId = userId
                    };

                }
            }
                    await repo.AddAsync<Material>(material);
                    await repo.SaveChangesAsync();
        }
        public async Task ConvertPresentationToJpeg(IFormFile file, string userId, int lessonId)
        {
            List<Material> urls = new List<Material>();

            using (var input = file.OpenReadStream())
            {

                using (IPresentation pptx = Presentation.Open(input))
                {
                    pptx.PresentationRenderer = new PresentationRenderer();

                    List<ImageUploadParams> uploadParams = new List<ImageUploadParams>();
                    Stream[] images = pptx.RenderAsImages(ExportImageFormat.Jpeg);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        int i = 1;
                        foreach (Stream imageStream in images)
                        {
                            imageStream.Position = 0;

                            uploadParams.Add(new ImageUploadParams()
                            {
                                File = new FileDescription($"{i}", imageStream),
                                Folder = "presentation",
                            });

                            i++;
                        }

                        foreach (var upload in uploadParams)
                        {
                            var result = await this.cloudinary.UploadAsync(upload);

                            if (result.Error != null)
                            {
                                throw new InvalidOperationException(result.Error.Message);
                            }

                            urls.Add(new Material
                            {
                                UrlPath = result.Url.ToString(),
                                LessonId = lessonId,
                                UserId = userId
                            });
                        }
                    }
                }
            }

            await repo.AddRangeAsync<Material>(urls);
            await repo.SaveChangesAsync();
        }


        public async Task ZipUpload(byte[] file, string userId, int lessonId)
        {
            using (Stream input = new MemoryStream(file))
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription("raw",input),
                    Folder = "zips",
                };

                var result =  await this.cloudinary.UploadAsync("auto", null, new FileDescription("ppt.zip", input));

                if (result.Error != null)
                {
                    throw new InvalidOperationException(result.Error.Message);
                }

                var url = result.Url.ToString().Replace("http", "https");

                var material = new Material
                {
                    UrlPath = url,
                    LessonId = 1,
                    UserId = userId
                };


                await repo.AddAsync<Material>(material);
                await repo.SaveChangesAsync();
            }
        }
    }
    
}
        //public async Task ZipUpload(IFormFile file, string userId, int lessonId)
        //{
        //    using (var input = file.OpenReadStream())
        //    {
        //        var uploadParams = new ImageUploadParams()
        //        {
        //            File = new FileDescription(userId, input),
        //            Folder = "zips"
        //        };

        //        var result = await this.cloudinary.UploadAsync(uploadParams);

        //        if (result.Error != null)
        //        {
        //            throw new InvalidOperationException(result.Error.Message);
        //        }

        //        var material = new Material
        //        {
        //            UrlPath = result.Url.ToString(),
        //            LessonId = lessonId,
        //            UserId = userId
        //        };


        //        await repo.AddAsync<Material>(material);
        //        await repo.SaveChangesAsync();
        //    }
        //}
