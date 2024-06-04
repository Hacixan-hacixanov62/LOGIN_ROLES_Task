using System.ComponentModel.DataAnnotations;

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Accounts
{
    public class RegisterVM
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string  Username { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Email is invalid")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfrimPassword { get; set; }

    }
}
