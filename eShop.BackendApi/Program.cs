using eShop.Application.Catalog.Products;
using eShop.Data.EF;
using eShop.Utilities.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace eShop.BackendApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //a variable to hold configuration
            IConfiguration Configuration;

            var builder = WebApplication.CreateBuilder(args);
            Configuration = builder.Configuration;


            // Add services to the container.
            builder.Services.AddDbContext<EShopDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));

            // Add a custom Transient service.
            builder.Services.AddTransient<IPublicProductService, PublicProductService>();
            builder.Services.AddControllersWithViews();

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

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}