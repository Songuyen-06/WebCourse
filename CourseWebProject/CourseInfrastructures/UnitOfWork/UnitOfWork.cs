using CourseDomain;
using CourseDomain.Contracts;
using CourseInfrastructure;

namespace CourseInfrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoursesDbContext _dbContext;

        private ICourseRepository _courseRepository;
        private IReviewRepository _reviewRepository;
        private IEnrollmentRepository _enrollmentRepository;
        private ICheckoutRepository _checkoutRepository;
        private ICategoryRepository _categoryRepository;

        public UnitOfWork(CoursesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ICourseRepository ICourseRepository => _courseRepository ?? new CourseRepository(_dbContext);


        public IReviewRepository IReviewRepository => _reviewRepository ?? new ReviewRepository(_dbContext);


        public ICheckoutRepository ICheckoutRepository => _checkoutRepository ?? new CheckoutRepository(_dbContext);


        public IEnrollmentRepository IEnrollmentRepository => _enrollmentRepository ?? new EnrollmentRepository(_dbContext);

        public ICategoryRepository ICategoryRepository => _categoryRepository ?? new CategoryRepository(_dbContext);

       
        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }

        public async Task RollbackAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}
