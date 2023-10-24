using Corpassb.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;

namespace Corpassb.Areas.Admin.Services
{
    public class InitDbService
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "Admin@iAdmin";
            string adminPwd = "Abcd1234%5^^";

            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }

            if (await roleManager.FindByNameAsync("Admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = "Admin" };
                IdentityResult result = await userManager.CreateAsync(admin, adminPwd);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }
            }
        }
    }
}
