using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Models;
using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Categories;
using ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.ViewModels.Courses;

namespace ONE_TO_MANY_EDIT_AJAX_PRACTICE_Task.Services.Interface
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseVM>> GetAllAsync();
        Task<Course> GetByIdAsync(int id);
        Task<Course> GetByIdWithAllDatasAsync(int id);
        Task<IEnumerable<Course>> GetAllPaginateAsync(int page, int take);
        Task<int> GetCountAsync();
        IEnumerable<CourseAdminVM> GetMappedDatas(IEnumerable<Course> courses);
        Task CreateAsync(CourseCreateVM request);
        Task DeleteAsync(Course course);
        Task EditAsync(Course course, CourseEditVM request);
        Task DeleteCourseImageAsync(MainAndDeleteImageVM data);
        Task SetMainImageAsync(MainAndDeleteImageVM data);
    }
}
