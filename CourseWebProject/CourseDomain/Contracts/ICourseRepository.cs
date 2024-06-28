


namespace CourseDomain
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        public Course GetCourseByIdInclude();
        public Course GetContentCourseById(int courseId);


    }
}
