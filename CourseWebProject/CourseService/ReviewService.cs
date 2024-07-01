using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReviewService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<List<ReviewDTO>> GetListReviewByCourseId(int courseId)
        {
            return _mapper.Map<List<ReviewDTO>>(await _unitOfWork.ReviewRepository.GetListReviewByCourseId(courseId));
        }
        public async Task<List<ReviewDTO>> GetListReview()
        {
            return _mapper.Map<List<ReviewDTO>>(await _unitOfWork.ReviewRepository.GetListReviewByInclude().ToListAsync());
        }
    }
}
