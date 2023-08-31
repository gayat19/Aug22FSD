using CompanyApplication.Contexts;
using CompanyApplication.Interfaces;
using CompanyApplication.Models;
using CompanyApplication.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CompanyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            #region AddingConetexts
            builder.Services.AddDbContext<CompanyContext>(opts =>
            {
                opts.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            #endregion
            #region AddingUserderfinedServices
            builder.Services.AddScoped<IRepository<int, Department>, DepartmentRepository>();
            builder.Services.AddScoped<IRepository<int, Employee>, EmployeeRepository>();
            #endregion


            var app = builder.Build();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


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