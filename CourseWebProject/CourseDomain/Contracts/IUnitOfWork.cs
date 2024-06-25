
namespace CourseDomain.Contracts
{
    public interface IUnitOfWork
    {
        ICourseRepository CourseRepository { get; }
        IReviewRepository ReviewRepository { get; }
        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}
