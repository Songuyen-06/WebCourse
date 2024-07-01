
using CourseDomain.Contracts;

namespace CourseDomain
{
    public interface IUnitOfWork
    {
        ICourseRepository CourseRepository { get; }
        IReviewRepository ReviewRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        ICheckoutRepository CheckoutRepository { get; }

  

        IEnrollmentRepository EnrollmentRepository { get; }

        ISectionRepository SectionRepository { get; }

       
        Task Commit();
        Task Rollback();
    }
}
