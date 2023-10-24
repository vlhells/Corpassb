using Corpassb.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Corpassb.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        [Required(ErrorMessage = $"{_errorMessage}")]
        [Display(Name = "Логин:")]
        public string Login { get; set; }

        [Required(ErrorMessage = $"{_errorMessage}")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль:")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
