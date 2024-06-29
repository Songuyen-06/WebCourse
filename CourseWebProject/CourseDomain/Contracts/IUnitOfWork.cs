
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
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
