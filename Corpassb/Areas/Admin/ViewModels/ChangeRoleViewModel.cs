using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Corpassb.Areas.Admin.ViewModels
{
    public class ChangeRoleViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        public List<IdentityRole> AllRoles { get; set; }

        public IList<string> UserRoles { get; set; }

        public ChangeRoleViewModel()
        {
            AllRoles = new List<IdentityRole>();
            UserRoles = new List<string>();
        }
    }
}
