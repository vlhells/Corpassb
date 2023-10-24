using Corpassb.Areas.Admin.Models;
using Corpassb.Areas.Admin.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Corpassb
{
    public class Program
    {
        public static async Task Main()
        {
            var builder = WebApplication.CreateBuilder();

            string connection = builder.Configuration.GetConnectionString("EfCoreBasicDatabase");

            builder.Services.AddDbContext<CorpassbContext>(options =>
                options.UseSqlServer(connection));

            builder.Services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<CorpassbContext>();

            builder.Services.AddMvc();

            var app = builder.Build();

            app.UseStatusCodePages();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Admin", "{area:exists}/{controller=users}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            using (var scope = app.Services.CreateScope()) // Инициализация бд ролями и админом, если бд чиста.
            {
                var services = scope.ServiceProvider;

                try
                {
                    var userManager = services.GetRequiredService<UserManager<User>>();
                    var rolesManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    await InitDbService.InitializeAsync(userManager, rolesManager);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            app.Run();
        }
    }
}