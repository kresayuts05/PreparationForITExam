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
        private readonly IAnswerService answerService;

        public MaterialService(
            IRepository _repo,
            Cloudinary _cloudinary,
            IAnswerService _answerService)
        {
            cloudinary = _cloudinary;
            repo = _repo;
            answerService = _answerService;
        }

        public async Task ConvertPresentationToPdf(IFormFile file, string userId, int lessonId)
        {
            string lessonTitle = await repo.AllReadonly<Lesson>()
                   .Where(l => l.Id == lessonId)
                   .Where(l => l.IsActive == true)
                   .Select(l => l.Title)
                   .FirstOrDefaultAsync();

            LessonMaterial material = new LessonMaterial();

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

                    var url = result.Url.ToString().Replace("http", "https");

                    material = new LessonMaterial
                    {
                        UrlPath = url,
                        Name = lessonTitle + " presentation",
                        FileFormat = ".pdf",
                        LessonId = lessonId,
                        UserId = userId
                    };
                }
            }
            await repo.AddAsync<LessonMaterial>(material);
            await repo.SaveChangesAsync();
        }
        public async Task ConvertPresentationToJpeg(IFormFile file, string userId, int lessonId)
        {
            List<LessonMaterial> urls = new List<LessonMaterial>();
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

                            urls.Add(new LessonMaterial
                            {
                                UrlPath = result.Url.ToString(),
                                Name = lessonTitle + " presentation",
                                FileFormat = ".jpg",
                                LessonId = lessonId,
                                UserId = userId
                            });
                        }
                    }
                }
            }

            await repo.AddRangeAsync<LessonMaterial>(urls);
            await repo.SaveChangesAsync();
        }
        public async Task ZipUpload(byte[] file, string userId, int lessonId, bool IsForExercise)
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


                if (IsForExercise == false)
                {
                    var material = new LessonMaterial
                    {
                        Name = $"{userId} zip",
                        UrlPath = url,
                        FileFormat = ".zip",
                        LessonId = lessonId,
                        UserId = userId
                    };
                    await repo.AddAsync<LessonMaterial>(material);
                }
                else
                {
                    var material = new ExerciseMaterial
                    {
                        Name = $"{userId} zip",
                        UrlPath = url,
                        FileFormat = ".zip",
                        ExerciseId = lessonId,
                        UserId = userId
                    };

                    await repo.AddAsync<ExerciseMaterial>(material);
                }

                await repo.SaveChangesAsync();
            }
        }
        public async Task ZipUpload(byte[] file, string userId, int lessonId, bool IsForExercise, bool isStudentMaterial)
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


                if (IsForExercise == false)
                {
                    var material = new LessonMaterial
                    {
                        Name = $"{userId} zip",
                        UrlPath = url,
                        FileFormat = ".zip",
                        LessonId = lessonId,
                        UserId = userId
                    };
                    await repo.AddAsync<LessonMaterial>(material);
                }
                else
                {
                    var material = new ExerciseMaterial
                    {
                        Name = $"{userId} zip",
                        UrlPath = url,
                        FileFormat = ".zip",
                        ExerciseId = lessonId,
                        UserId = userId,
                        IsStudentMaterial = isStudentMaterial
                    };

                    await repo.AddAsync<ExerciseMaterial>(material);
                }

                await repo.SaveChangesAsync();
            }
        }
        public async Task ZipUploadAnswer(byte[] file, string userId, int exerciseMaterialId)
        {
            using (Stream input = new MemoryStream(file))
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription("raw", input),
                    Folder = "zips",
                };

                var result = await this.cloudinary.UploadAsync("raw", null, new FileDescription($"{userId}.zip", input));

                if (result.Error != null)
                {
                    throw new InvalidOperationException(result.Error.Message);
                }

                var url = result.Url.ToString().Replace("http", "https");

                var material = new Answer
                {
                    Name = $"{userId} zip",
                    UrlPath = url,
                    FileFormat = ".zip",
                    ExerciseMaterialId = exerciseMaterialId,
                    UserId = userId,
                    IsActive = true,
                };

                await repo.AddAsync<Answer>(material);
            }

            await repo.SaveChangesAsync();

        }
        public async Task ConvertWordDocumentToPdf(IFormFile file, string userId, int lessonId, bool IsForExercise)
        {
            string lessonTitle = await repo.AllReadonly<Lesson>()
                   .Where(l => l.Id == lessonId)
                   .Where(l => l.IsActive == true)
                   .Select(l => l.Title)
                   .FirstOrDefaultAsync();


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

                        var url = result.Url.ToString().Replace("http", "https");

                        if (IsForExercise)
                        {
                            var material = new LessonMaterial
                            {
                                UrlPath = url,
                                Name = lessonTitle + " docx",
                                FileFormat = ".pdf",
                                UserId = userId,
                                LessonId = lessonId
                            };
                            await repo.AddAsync<LessonMaterial>(material);
                        }
                        else
                        {
                            var material = new ExerciseMaterial
                            {
                                UrlPath = url,
                                Name = lessonTitle + " docx",
                                FileFormat = ".pdf",
                                UserId = userId,
                                ExerciseId = lessonId
                            };

                            await repo.AddAsync<ExerciseMaterial>(material);
                        }

                    }
                }
                await repo.SaveChangesAsync();
            }
        }
        public async Task ConvertWordDocumentsToPdf(List<IFormFile> files, string userId, int lessonId, bool IsForExercise)
        {
            string lessonTitle = await repo.AllReadonly<Lesson>()
                   .Where(l => l.Id == lessonId)
                   .Where(l => l.IsActive == true)
                   .Select(l => l.Title)
                   .FirstOrDefaultAsync();

            List<LessonMaterial> materialsL = new List<LessonMaterial>();
            List<ExerciseMaterial> materialsE = new List<ExerciseMaterial>();

            if (IsForExercise)
            {
                foreach (var file in files)
                {
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

                                var url = result.Url.ToString().Replace("http", "https");

                                var material = new ExerciseMaterial
                                {
                                    UrlPath = url,
                                    Name = lessonTitle + " docx",
                                    FileFormat = ".pdf",
                                    UserId = userId,
                                    ExerciseId = lessonId
                                };

                                materialsE.Add(material);
                            }

                        }
                    }
                }

                await repo.AddRangeAsync<ExerciseMaterial>(materialsE);
            }
            else
            {
                foreach (var file in files)
                {
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

                                var url = result.Url.ToString().Replace("http", "https");

                                var material = new LessonMaterial
                                {
                                    UrlPath = url,
                                    Name = lessonTitle + " docx",
                                    FileFormat = ".pdf",
                                    UserId = userId,
                                    LessonId = lessonId
                                };

                                materialsL.Add(material);
                            }
                        }
                    }
                }

                await repo.AddRangeAsync<LessonMaterial>(materialsL);
            }

            await repo.SaveChangesAsync();
        }
        public async Task<string> GetPresentationUrlByLessonId(int lessonId)
        {
            string url = await repo.AllReadonly<LessonMaterial>()
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
        public async Task<string> GetDocumentUrlByExerciseId(int exerciseId)
        {
            string url = await repo.AllReadonly<ExerciseMaterial>()
                .Where(m => m.ExerciseId == exerciseId)
                .Where(m => m.IsActive == true)
                .Where(m => m.Name.Contains("docx"))
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
            var materials = await repo.AllReadonly<LessonMaterial>()
                .Where(m => m.LessonId == lessonId)
                .Where(m => m.IsActive == true)
                .Where(m => m.Name.Contains("presentation") == false)
                .Select(m => new MaterialModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    UrlPath = m.UrlPath,
                    FileFormat = m.FileFormat,
                    UserName = m.User.FirstName + " " + m.User.LastName,
                    UserId = m.UserId,
                    LessonId = m.LessonId
                })
                .ToListAsync();

            return materials;
        }
        public async Task<List<MaterialModel>> GetAllMaterialsForExerciseById(int exerciseId)
        {
            var materials = await repo.AllReadonly<ExerciseMaterial>()
                .Where(m => m.ExerciseId == exerciseId)
                .Where(m => m.IsActive == true && m.IsStudentMaterial == false)
                .Where(m => m.Name.Contains("docx") == false)
                .Select(m => new MaterialModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    UrlPath = m.UrlPath,
                    FileFormat = m.FileFormat,
                    UserName = m.User.FirstName + " " + m.User.LastName,
                    UserId = m.UserId,
                    LessonId = m.ExerciseId
                })
                .ToListAsync();

            return materials;
        }
        public async Task<List<MaterialModel>> GetAllMaterialsForExerciseByIdByStudent(int exerciseId)
        {
            var materials = await repo.AllReadonly<ExerciseMaterial>()
                .Where(m => m.ExerciseId == exerciseId)
                .Where(m => m.IsActive == true && m.IsStudentMaterial == true)
                .Where(m => m.Name.Contains("docx") == false)
                .Select(m => new MaterialModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    UrlPath = m.UrlPath,
                    FileFormat = m.FileFormat,
                    UserName = m.User.FirstName + " " + m.User.LastName,
                    UserId = m.UserId,
                    LessonId = m.ExerciseId
                })
                .ToListAsync();

            return materials;
        }
        public async Task DeleteMaterial(int id, bool IsForExercise)
        {
            if (IsForExercise)
            {
                var material = await repo.GetByIdAsync<ExerciseMaterial>(id);
                material.IsActive = false;
            }
            else
            {
                var material = await repo.GetByIdAsync<LessonMaterial>(id);
                material.IsActive = false;
            }

            await repo.SaveChangesAsync();
        }
        public async Task<List<MaterialModel>> GetAllMaterialsOfStudentByUserId(string id)
        {
            var materials = await repo.AllReadonly<ExerciseMaterial>()
              .Where(m => m.UserId == id)
              .Where(m => m.IsActive == true && m.IsStudentMaterial == true)
              .Select(m => new MaterialModel
              {
                  Id = m.Id,
                  Name = m.Name,
                  UrlPath = m.UrlPath,
                  FileFormat = m.FileFormat,
                  UserName = m.User.FirstName + " " + m.User.LastName,
                  UserId = m.UserId,
                  LessonId = m.ExerciseId
              })
              .ToListAsync();

            foreach (var m in materials)
            {
                m.Answers = await answerService.GetAnswersByMaterialId(m.Id);
            }

            return materials;
        }
        public async Task<List<MaterialModel>> GetAllMaterialsForExerciseByUserId(string userId)
        {
            var materials = await repo.AllReadonly<ExerciseMaterial>()
                 .Where(m => m.UserId == userId)
                 .Where(m => m.IsActive == true)
                 .Select(m => new MaterialModel
                 {
                     Id = m.Id,
                     Name = m.Name,
                     UrlPath = m.UrlPath,
                     FileFormat = m.FileFormat,
                     UserName = m.User.FirstName + " " + m.User.LastName,
                     UserId = m.UserId,
                     LessonId = m.ExerciseId
                 })
                 .ToListAsync();

            return materials;
        }
        public async Task<List<MaterialModel>> GetAllMaterialsForLessonByUserId(string userId)
        {
            var materials = await repo.AllReadonly<LessonMaterial>()
                 .Where(m => m.UserId == userId)
                 .Where(m => m.IsActive == true)
                 .Select(m => new MaterialModel
                 {
                     Id = m.Id,
                     Name = m.Name,
                     UrlPath = m.UrlPath,
                     FileFormat = m.FileFormat,
                     UserName = m.User.FirstName + " " + m.User.LastName,
                     UserId = m.UserId,
                     LessonId = m.LessonId
                 })
                 .ToListAsync();

            return materials;
        }
        public async Task<string> GetUserIdByMaterialId(int id, bool isForExercise)
        {
            if (isForExercise)
            {
                var model = await repo.GetByIdAsync<ExerciseMaterial>(id);

                return model.UserId;
            }
            else
            {
                var model = await repo.GetByIdAsync<LessonMaterial>(id);

                return model.UserId;
            }
        }
        public async Task<int> GetExerciseIdByMaterialId(int id)
        {
            var model = await repo.GetByIdAsync<ExerciseMaterial>(id);

            return model.ExerciseId;
        }
    }
}