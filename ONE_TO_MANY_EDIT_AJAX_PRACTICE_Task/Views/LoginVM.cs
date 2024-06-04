using System.ComponentModel.DataAnnotations;

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Views
{
    public class LoginVM
    {
        [Required]
        public string EmailOrUsername { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
