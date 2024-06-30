
using CourseDomain.Contracts;

namespace CourseDomain
{
    public interface IUnitOfWork
    {
        ICourseRepository ICourseRepository { get; }
        IReviewRepository IReviewRepository { get; }

        ICategoryRepository ICategoryRepository { get; }

        ICheckoutRepository ICheckoutRepository { get; }

  

        IEnrollmentRepository IEnrollmentRepository { get; }

        ISectionRepository ISectionRepository { get; }

       
        Task Commit();
        Task Rollback();
    }
}
