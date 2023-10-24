using Corpassb.Models;
using System.ComponentModel.DataAnnotations;

namespace Corpassb.Areas.Admin.ViewModels
{
    public class EditUserViewModel: ViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = $"{_errorMessage}")]
        [Display(Name = "Логин:")]
        public string Login { get; set; }

        [Required(ErrorMessage = $"{_errorMessage}")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль:")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email:")]
        public string Email { get; set; }
    }
}
