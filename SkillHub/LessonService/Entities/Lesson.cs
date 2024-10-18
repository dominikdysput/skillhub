namespace LessonService.Entities
{
    public class Lesson : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Section { get; set; }
        public string Content { get; set; }
    }
}
