using PizzaStoreApp.Interfaces;
using PizzaStoreApp.Models;
using PizzaStoreApp.Repositories;
using PizzaStoreApp.Services;

namespace PizzaStoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            #region InjectUSerdefinedServices
            builder.Services.AddScoped<IRepository<int,PizzaWithPic>,PizzaRepository>();
            builder.Services.AddScoped<IPizzaService,PizzaServicecs>();
            builder.Services.AddScoped<IManagePizzaService, PizzaServicecs>();
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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