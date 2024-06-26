using CourseDomain;

namespace CourseServices
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CourseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Course course)
        {
            _unitOfWork.ICourseRepository.Add(course);
            _unitOfWork.Commit();
        }

        public void Delete(Course course)
        {
            _unitOfWork.ICourseRepository.Remove(course);
            _unitOfWork.Commit();
        }

        public Course GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourses()
        {
            return _unitOfWork.ICourseRepository.GetAll().ToList();
        }

        

        public void Update(Course course)
        {
            _unitOfWork.ICourseRepository.Update(course);
            _unitOfWork.Commit();
        }
    }
}
