using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SharePoint.Client;
using PreparationForITExam.Core.Hubs;
using PreparationForITExam.Infrastructure.Data;
using PreparationForITExam.Infrastructure.Data.Entities;
using System.Security;

//"Data Source=mssql6.asphostbg.net,14330;Initial Catalog=srebchev_preparationforitexam;User ID=srebchev_kresa;Password=Kresa3466@"
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
        builder.Services.AddSignalR();

        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncfusionKey);

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

            //endpoints.MapHub<ChatHub>("/Chat/Index");
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

}