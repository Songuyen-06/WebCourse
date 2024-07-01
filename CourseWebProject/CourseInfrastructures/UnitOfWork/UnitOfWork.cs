using AutoMapper;
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
        private ISectionRepository _sectionRepository;
        public UnitOfWork(CoursesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
        }
        public ICourseRepository CourseRepository => _courseRepository ?? new CourseRepository(_dbContext);


        public IReviewRepository ReviewRepository => _reviewRepository ?? new ReviewRepository(_dbContext);


        public ICheckoutRepository CheckoutRepository => _checkoutRepository ?? new CheckoutRepository(_dbContext);


        public IEnrollmentRepository EnrollmentRepository => _enrollmentRepository ?? new EnrollmentRepository(_dbContext);

        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_dbContext);

        public ISectionRepository SectionRepository => _sectionRepository ?? new SectionRepository(_dbContext);


        

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task Rollback()
        {
            await _dbContext.DisposeAsync();
        }

        
    }
}
