namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Models
{
    public class CourseImage 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
