using LessonService.Entities;
using LessonService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LessonService.Data
{
    public class LessonRepository : ILessonsRepository
    {
        private readonly LessonServiceDbContext _context;
        public LessonRepository(LessonServiceDbContext context)
        {
            _context = context;
        }
        public async Task<Lesson> CreateOrUpdateLesson(Lesson lesson)
        {
            await _context.Lessons.AddAsync(lesson);

            return lesson;
        }

        public async Task<Lesson?> GetLessonByIdAsync(int id)
        {
            return await _context.Lessons.FindAsync(id);
        }

        public async Task<IEnumerable<Lesson>> GetLessonsAsync()
        {
            return await _context.Lessons.ToArrayAsync();
        }
    }
}
