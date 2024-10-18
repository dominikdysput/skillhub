using LessonService.Entities;

namespace LessonService.Interfaces
{
    public interface ILessonsRepository
    {
        Task<Lesson> CreateOrUpdateLesson(Lesson lesson);
        Task<IEnumerable<Lesson>> GetLessonsAsync();
        Task<Lesson?> GetLessonByIdAsync(int id);
    }
}
