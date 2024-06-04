namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Courses
{
    public class CourseVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string MainImage { get; set; }
    }
}
