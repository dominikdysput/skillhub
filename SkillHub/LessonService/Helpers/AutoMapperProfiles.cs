using AutoMapper;
using LessonService.Dtos;
using LessonService.Entities;

namespace LessonService.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Lesson, LessonForDetailDto>();
            CreateMap<LessonForCreateOrUpdateDto, Lesson>();
        }
    }
}
