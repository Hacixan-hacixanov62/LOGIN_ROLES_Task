using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Courses;
using System.ComponentModel.DataAnnotations;

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Courses
{
    public class CourseEditVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Price { get; set; }
        public string DiscountPrice { get; set; }
        public int CategoryId { get; set; }
        public List<CourseImageEditVM> Images { get; set; }
        public List<IFormFile> NewImages { get; set; }
    }
}
