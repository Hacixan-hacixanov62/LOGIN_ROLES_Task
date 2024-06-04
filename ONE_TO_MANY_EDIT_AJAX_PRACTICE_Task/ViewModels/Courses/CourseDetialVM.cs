namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Courses
{
    public class CourseDetialVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string Category { get; set; }
        public List<CourseImageVM> Images { get; set; }
    }
}
