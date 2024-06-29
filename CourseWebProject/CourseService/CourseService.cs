using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
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

        public void AddCourse(Course course)
        {
            _unitOfWork.ICourseRepository.Add(course);
            _unitOfWork.Commit();
        }

        public void DeleteCourse(Course course)
        {
            _unitOfWork.ICourseRepository.Remove(course);
            _unitOfWork.Commit();
        }

        public CourseDTO GetCourseById(int courseId)
        {
            return _mapper.Map<CourseDTO>(_unitOfWork.ICourseRepository.GetCourseById(courseId));
        }

        public List<CourseDTO> GetListCourse()
        {
            return _mapper.Map<List<CourseDTO>>( _unitOfWork.ICourseRepository.GetAll().ToList());
        }



        public void UpdateCourse(Course course)
        {
            _unitOfWork.ICourseRepository.Update(course);
            _unitOfWork.Commit();
        }
    }
}
