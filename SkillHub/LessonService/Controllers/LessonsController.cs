using AutoMapper;
using LessonService.Dtos;
using LessonService.Entities;
using LessonService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LessonService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessonsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LessonsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("GetLessons")]
        public async Task<IActionResult> GetLessons()
        {
            var lessons = await _unitOfWork.LessonsRepository.GetLessonsAsync();

            return Ok(lessons);
        }

        [HttpGet("GetLesson")]
        public async Task<IActionResult> GetLesson(int id)
        {
            var lesson = await _unitOfWork.LessonsRepository.GetLessonByIdAsync(id);
            var lessonToReturn = _mapper.Map<LessonForDetailDto>(lesson);
            
            return Ok(lessonToReturn);
        }

        [HttpPut]
        public async Task<IActionResult> CreateOrUpdateLesson(LessonForCreateOrUpdateDto lesson)
        {
            var lessonToCreateOrUpdate = _mapper.Map<Lesson>(lesson);
            var lessonResult = await _unitOfWork.LessonsRepository.CreateOrUpdateLesson(lessonToCreateOrUpdate);

            return Ok(lessonResult);
        }
    }
}
