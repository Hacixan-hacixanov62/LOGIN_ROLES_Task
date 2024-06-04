using Microsoft.AspNetCore.Authentication;
using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Categories;
using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Courses;

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Home
{
    public class HomeVM
    {
        public  IEnumerable<CategoryVM>  Categories { get; set; }
        public IEnumerable<CourseVM> Courses { get; set; }

    }
}
