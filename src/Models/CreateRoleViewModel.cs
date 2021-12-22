using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role name")]
        public string RoleName { get; set; }
    }
}