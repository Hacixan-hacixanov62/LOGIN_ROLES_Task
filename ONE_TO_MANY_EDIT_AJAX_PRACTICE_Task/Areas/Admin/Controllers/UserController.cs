using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Models;
using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Users;
using System.Security.Principal;

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<AppUser> userManager,
                              RoleManager<IdentityRole> roleManager )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async  Task<IActionResult> Index()
        {

            var users =  _userManager.Users.ToList();

            List<UserRoleVM> usersWithRoles = new();

            foreach ( var item in users )
            {
                var roles = await _userManager.GetRolesAsync(item);
                string userRoles = String.Join(",", roles.ToArray());

                usersWithRoles.Add(new UserRoleVM
                {
                    FullName =item.FullName,
                    Email= item.Email,
                    UserName =item.UserName,
                    Roles=userRoles
                });
            }

            return View(usersWithRoles);
        }





    }
}

// user id ; 0e694c10-fdf8-4032-b38b-6e44db127c1c