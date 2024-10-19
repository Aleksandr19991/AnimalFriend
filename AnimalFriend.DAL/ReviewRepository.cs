using AnimalFriend.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.DAL
{
    public class ReviewRepository
    {
        Context context = new Context();

        public int AddReview(ReviewDto review)
        {
           context.Reviews.Add(review);
           context.SaveChanges();

           return review.Id;
        }

        public ReviewDto GetReviewByShelterId(int shelterId)
        {
            var review = context.Reviews.Where(r => r.ShelterId == shelterId).FirstOrDefault();

            return review;
        }


    }
}
