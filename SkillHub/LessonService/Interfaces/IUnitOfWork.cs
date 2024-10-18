namespace LessonService.Interfaces
{
    public interface IUnitOfWork
    {
        ILessonsRepository LessonsRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}
