using Microsoft.AspNetCore.Identity;

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
