using AnimalFriend.BLL.Mappings;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using AutoMapper;

namespace AnimalFriend.BLL
{
    public class ReviewServise
    {
        private ReviewRepository ReviewRepository { get; set; }

        private Mapper _mapper;

        public ReviewServise()
        {
            ReviewRepository = new ReviewRepository();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new ReviewMapperProfile());
            });
            _mapper = new Mapper(config);
        }

        public int AddReview(ReviewInputModel review)
        {
            var reviewDto = _mapper.Map<ReviewDto>(review);

            var reviewId = ReviewRepository.AddReview(reviewDto);

            return reviewId;
        }

        public ReviewOutputModel GetReviewByShelterId(int shelterId)
        {
            var reviewDto = ReviewRepository.GetReviewByShelterId(shelterId);

            var review = _mapper.Map<ReviewOutputModel>(reviewDto);

            return review;
        }
    }
}
