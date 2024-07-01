using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CourseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddCourse(Course course)
        {
            _unitOfWork.CourseRepository.Add(course);
            await _unitOfWork.Commit();
        }

        public async Task DeleteCourse(Course course)
        {
            _unitOfWork.CourseRepository.Remove(course);
            await _unitOfWork.Commit();
        }

        public async Task<CourseDTO> GetCourseById(int courseId)
        {
            return _mapper.Map<CourseDTO>(await _unitOfWork.CourseRepository.GetCourseById(courseId));
        }

        public async Task<List<CourseDTO>> GetListCourse()
        {
            return _mapper.Map<List<CourseDTO>>(await _unitOfWork.CourseRepository.GetListCourseByInclude().ToListAsync());
        }



        public async Task UpdateCourse(Course course)
        {
            _unitOfWork.CourseRepository.Update(course);
            await _unitOfWork.Commit();
        }
    }
}
