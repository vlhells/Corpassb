using Corpassb.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Corpassb.Areas.Admin.Models
{
    public class User: IdentityUser
    {
        public User() // Для инициализации бд сервисом из папки Admin.
        {

        }

        public User(CreateUserViewModel model) // Для создания пользователя из админ-панели.
        {
            Email = model.Email;
            UserName = model.Login;
        }
    }
}
