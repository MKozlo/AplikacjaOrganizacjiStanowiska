using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Controllers;
using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Seedowanie danych
            using (var serviceScope = app.Services.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();
                var seeder = new AppSeeder(context);
                seeder.Seed();
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
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
