using System.ComponentModel.DataAnnotations;

namespace Corpassb.Areas.Admin.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        public string NewPassword { get; set; }
    }
}
