using LessonService.Interfaces;

namespace LessonService.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LessonServiceDbContext _context;
        public UnitOfWork(LessonServiceDbContext context)
        {
            _context = context;
        }
        public ILessonsRepository LessonsRepository => new LessonRepository(_context);

        public async Task<bool> Complete()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public bool HasChanges()
        {
            _context.ChangeTracker.DetectChanges();
            var changes = _context.ChangeTracker.HasChanges();

            return changes;
        }
    }
}
