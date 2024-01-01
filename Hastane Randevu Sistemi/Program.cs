using Hospital.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Hospital.Utilities;
using Hospital.Repositories.Interfaces;
using Hospital.Repositories.Implementation;
using Microsoft.AspNetCore.Identity.UI.Services;
using Hospital.Services;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using System.Reflection;
using WebApplication3.Services;
using Microsoft.Extensions.Options;
namespace Hastane_Randevu_Sistemi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

            #region Localizer
            builder.Services.AddSingleton<LanguageService>();
            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
            builder.Services.AddMvc().AddViewLocalization().AddDataAnnotationsLocalization(options =>
                options.DataAnnotationLocalizerProvider = (type, factory) =>
                {
                    var assemblyName = new AssemblyName(typeof(SharedResource).GetTypeInfo().Assembly.FullName);
                    return factory.Create(nameof(SharedResource), assemblyName.Name);
                });

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportCultures = new List<CultureInfo>
    {
        new CultureInfo("en-US"),
        new CultureInfo("fr-FR"),
        new CultureInfo("tr-TR"),
    };
                options.DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR");
                options.SupportedCultures = supportCultures;
                options.SupportedUICultures = supportCultures;
                options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
            });
            #endregion

            // Add services to the container.
            builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<ApplicationDbContext>(options=>
			options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

               builder.Services.AddIdentity<IdentityUser,IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

			builder.Services.AddScoped<IDbInitializer,DbInitializer>();
			builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();
			builder.Services.AddScoped<IEmailSender,EmailSender>();
			builder.Services.AddTransient<IHospitalInfo, HospitalInfoService>();
			builder.Services.AddTransient<IDoctorService, DoctorService>();
            builder.Services.AddTransient<IRoomService, RoomService>();
            builder.Services.AddTransient<IContactService, ContactService>();
            builder.Services.AddTransient<IApplicationUserService, ApplicationUserService>();

            builder.Services.AddRazorPages();
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			DataSedding();
            app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);
            app.UseRouting();
               app.UseAuthentication();;

			app.UseAuthorization();
			app.MapRazorPages();
			app.MapControllerRoute(
				name: "default",
				pattern: "{Area=admin}/{controller=Hospitals}/{action=Index}/{id?}");

			app.Run();
			void DataSedding(){
				using (var scope = app.Services.CreateScope())
				{
					var dbInitializer = scope.ServiceProvider.
						GetRequiredService<IDbInitializer>();
					dbInitializer.Initialize();
						
				}

			}
		}
	}
}