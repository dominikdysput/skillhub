namespace LessonService.Dtos
{
    public class LessonForCreateOrUpdateDto 
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Section { get; set; }
        public string Content { get; set; }
    }
}
