using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Infrastructure.Data.Entities;
using Syncfusion.Presentation;
using Syncfusion.PresentationRenderer;
using PreparationForITExam.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Http;
using Syncfusion.Pdf;
using Microsoft.EntityFrameworkCore;
using PreparationForITExam.Core.Models.Material;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;

namespace PreparationForITExam.Core.Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IRepository repo;
        private readonly Cloudinary cloudinary;

        public MaterialService(
            IRepository _repo,
            Cloudinary _cloudinary)
        {
            cloudinary = _cloudinary;
            repo = _repo;
        }

        public async Task ConvertPresentationToPdf(IFormFile file, string userId, int lessonId)
        {
            string lessonTitle = await repo.AllReadonly<Lesson>()
                   .Where(l => l.Id == lessonId)
                   .Where(l => l.IsActive == true)
                   .Select(l => l.Title)
                   .FirstOrDefaultAsync();

            Material material = new Material();

            using (var input = file.OpenReadStream())
            {
                using (IPresentation pptxDoc = Presentation.Open(input))
                {
                    PdfDocument pdfDcument = PresentationToPdfConverter.Convert(pptxDoc);
                    MemoryStream ms = new MemoryStream();
                    pdfDcument.Save(ms);
                    ms.Position = 0;

                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription($"{lessonTitle}.pdf", ms)
                    };

                    var result = await this.cloudinary.UploadAsync(uploadParams);

                    if (result.Error != null)
                    {
                        throw new InvalidOperationException(result.Error.Message);
                    }

                    material = new Material
                    {
                        UrlPath = result.Url.ToString(),
                        Name = lessonTitle + " presentation",
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
            string lessonTitle = await repo.AllReadonly<Lesson>()
                 .Where(l => l.Id == lessonId)
                 .Where(l => l.IsActive == true)
                 .Select(l => l.Title)
                 .FirstOrDefaultAsync();

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
                                Folder = $"{lessonTitle}",
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
                                Name = lessonTitle + " presentation",
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
            string lessonTitle = await repo.AllReadonly<Lesson>()
                .Where(l => l.Id == lessonId)
                .Where(l => l.IsActive == true)
                .Select(l => l.Title)
                .FirstOrDefaultAsync();

            using (Stream input = new MemoryStream(file))
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription("raw", input),
                    Folder = "zips",
                };

                var result = await this.cloudinary.UploadAsync("raw", null, new FileDescription($"{lessonTitle}.zip", input));

                if (result.Error != null)
                {
                    throw new InvalidOperationException(result.Error.Message);
                }

                var url = result.Url.ToString().Replace("http", "https");

                var material = new Material
                {
                    Name = $"{userId} zip",
                    UrlPath = url,
                    LessonId = lessonId,
                    UserId = userId
                };

                await repo.AddAsync<Material>(material);
                await repo.SaveChangesAsync();
            }
        }

        public async Task<string> GetPresentationUrlByLessonId(int lessonId)
        {
            string url = await repo.AllReadonly<Material>()
                .Where(m => m.LessonId == lessonId)
                .Where(m => m.IsActive == true)
                .Where(m => m.Name.Contains("presentation"))
                .Select(m => m.UrlPath)
                .FirstOrDefaultAsync();

            if (url == null)
            {
                throw new NullReferenceException(nameof(url));
            }

            return url;
        }

        public async Task<List<MaterialModel>> GetAllMaterialsForLessonById(int lessonId)
        {
            var materials = await repo.AllReadonly<Material>()
                .Where(m => m.LessonId == lessonId)
                .Where(m => m.IsActive == true)
                .Where(m => m.Name.Contains("presentation") == false)
                .Select(m => new MaterialModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    UrlPath = m.UrlPath
                })
                .ToListAsync();

            return materials;
        }

        public async Task ConvertWordDocumentToPdf(IFormFile file, string userId, int lessonId)
        {
            string lessonTitle = await repo.AllReadonly<Lesson>()
                   .Where(l => l.Id == lessonId)
                   .Where(l => l.IsActive == true)
                   .Select(l => l.Title)
                   .FirstOrDefaultAsync();

            Material material = new Material();

            using (var docStream = file.OpenReadStream())
            {
                using (WordDocument wordDocument = new WordDocument(docStream, Syncfusion.DocIO.FormatType.Docx))
                {
                    using (DocIORenderer renderer = new DocIORenderer())
                    {
                        PdfDocument pdfDocument = renderer.ConvertToPDF(wordDocument);
                        MemoryStream ms = new MemoryStream();
                        pdfDocument.Save(ms);
                        ms.Position = 0;

                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription($"{lessonTitle}.pdf", ms)
                        };

                        var result = await this.cloudinary.UploadAsync(uploadParams);

                        if (result.Error != null)
                        {
                            throw new InvalidOperationException(result.Error.Message);
                        }

                        material = new Material
                        {
                            UrlPath = result.Url.ToString(),
                            Name = lessonTitle + " docx",
                            LessonId = lessonId,
                            UserId = userId
                        };
                    }
                }
                await repo.AddAsync<Material>(material);
                await repo.SaveChangesAsync();
            }
        }
    }
}