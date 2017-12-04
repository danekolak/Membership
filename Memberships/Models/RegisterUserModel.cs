using System.ComponentModel.DataAnnotations;

namespace Memberships.Models
{
    public class RegisterUserModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {1} characters long.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public bool AcceptUserAgreement { get; set; }




    }
}
