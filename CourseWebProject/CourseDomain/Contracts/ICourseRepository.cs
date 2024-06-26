


namespace CourseDomain
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        public List<Course> GetCourseByIdIncludeRating(int courseId);
        public List<Course>GetContentCourseById(int courseId);


    }
}
