using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SharePoint.Client;
using PreparationForITExam.Infrastructure.Data;
using PreparationForITExam.Infrastructure.Data.Entities;
using System.Security;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        var syncfusionKey = builder.Configuration.GetValue<string>("Syncfusion:Key");

        builder.Services.AddDbContext<PreparationForITExamDbContext>(options =>
            options.UseSqlServer(connectionString));
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddDefaultIdentity<PreparationForITExam.Infrastructure.Data.Entities.User>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 4;
        })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<PreparationForITExamDbContext>();

        builder.Services.AddControllersWithViews(options =>
        {
            options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
        });

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/User/Login";
            options.LogoutPath = "/User/Logout";
        });

        builder.Services.AddApplicationServices();
        ConfigureCloudaryService(builder.Services, builder.Configuration);

        builder.Services.AddResponseCaching();

        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncfusionKey);

        //CreateFolderToSharePoint();
        //UploadfileToFolderInSharePoint();

        var app = builder.Build();


        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
            endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            endpoints.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
        });
        app.MapRazorPages();

        app.Run();
    }

    //Cloudinary api
    private static void ConfigureCloudaryService(IServiceCollection services, IConfiguration configuration)
    {
        var cloudName = configuration.GetValue<string>("AccountSettings:CloudName");
        var apiKey = configuration.GetValue<string>("AccountSettings:ApiKey");
        var apiSecret = configuration.GetValue<string>("AccountSettings:ApiSecret");

        if (new[] { cloudName, apiKey, apiSecret }.Any(string.IsNullOrWhiteSpace))
        {
            throw new ArgumentException("Please specify your Cloudinary account Information");
        }

        services.AddSingleton(new Cloudinary(new Account(cloudName, apiKey, apiSecret)));
    }

    //SharePoint
    //private static void CreateFolderToSharePoint()
    //{
    //    string userName = "kresatsvetkova05@pmgkk.com";
    //    string Password = "3466YUts";

    //    var securePassword = new SecureString();
    //    foreach (char c in Password)
    //    {
    //        securePassword.AppendChar(c);
    //    }

    //    using (var ctx = new ClientContext("https://pmgkk.sharepoint.com/sites/PreparationForITExam"))
    //    {
    //        ctx.Credentials = new Microsoft.SharePoint.Client.SharePointOnlineCredentials(userName, securePassword);
    //        Web web = ctx.Web;
    //        ctx.Load(web);
    //        ctx.ExecuteQuery();
    //        List byTitle = ctx.Web.Lists.GetByTitle("Materials");

    //        // New object of "ListItemCreationInformation" class
    //        ListItemCreationInformation listItemCreationInformation = new ListItemCreationInformation();

    //        // Below are options.
    //        // (1) File - This will create a file in the list or document library
    //        // (2) Folder - This will create a foder in list(if folder creation is enabled) or documnt library
    //        listItemCreationInformation.UnderlyingObjectType = FileSystemObjectType.Folder;

    //        // This will et the internal name/path of the file/folder
    //        listItemCreationInformation.LeafName = "NewFolderFromCSOM";

    //        ListItem listItem = byTitle.AddItem(listItemCreationInformation);

    //        // Set folder Name
    //        listItem["Title"] = "NewFolderFromCSOM";

    //        listItem.Update();
    //        ctx.ExecuteQuery();
    //    }

        
    //}

    //private static void UploadfileToFolderInSharePoint()
    //{
    //    string userName = "kresatsvetkova05@pmgkk.com";
    //    string Password = "3466YUts";

    //    var securePassword = new SecureString();
    //    foreach (char c in Password)
    //    {
    //        securePassword.AppendChar(c);
    //    }

    //    using (var ctx = new ClientContext("https://pmgkk.sharepoint.com/sites/PreparationForITExam/"))
    //    {
    //        ctx.Credentials = new Microsoft.SharePoint.Client.SharePointOnlineCredentials(userName, securePassword);
    //        Web web = ctx.Web;
    //        ctx.Load(web);
    //        ctx.ExecuteQuery();
    //        FileCreationInformation newFile = new FileCreationInformation();
    //        newFile.Content = System.IO.File.ReadAllBytes("C:\\Users\\kresa\\Downloads\\PPTtoPDF.pdf");
    //        newFile.Url = @"PPTtoPDF.pdf";
    //        List byTitle = ctx.Web.Lists.GetByTitle("Documents");
    //        Folder folder = byTitle.RootFolder.Folders.GetByUrl("NewFolderFromCSOM");
    //        ctx.Load(folder);
    //        ctx.ExecuteQuery();
    //        Microsoft.SharePoint.Client.File uploadFile = folder.Files.Add(newFile);
    //        uploadFile.CheckIn("checkin", CheckinType.MajorCheckIn);
    //        ctx.Load(byTitle);
    //        ctx.Load(uploadFile);
    //        ctx.ExecuteQuery();
    //        Console.WriteLine("done");
    //    }
    //}
}