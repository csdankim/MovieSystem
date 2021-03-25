using System;
using System.Collections.Generic;
using System.Text;
using MovieSystem.Data.Models;
using MovieSystem.Data.Repository;
using System.Threading.Tasks;

namespace MovieSystem.Data.Services
{
    public class ReviewService
    {
        IRepository<Review> reviewRepository;
        public ReviewService()
        {
            reviewRepository = new ReviewRepository();
        }
        public int AddReview(Review item)
        {
            return reviewRepository.Insert(item);
        }

        public int UpdateReview(Review item)
        {
            return reviewRepository.Update(item);
        }

        public int DeleteReview(int id)
        {
            return reviewRepository.Delete(id);
        }

        public IEnumerable<Review> GetAll()
        {
            return reviewRepository.GetAll();
        }

        public Review GetById(int id)
        {
            return reviewRepository.GetById(id);
        }

        //async
        public Task<int> AddReviewAsync(Review item)
        {
            return reviewRepository.InsertAsync(item);
        }

        public Task<int> UpdateReviewAsync(Review item)
        {
            return reviewRepository.UpdateAsync(item);
        }

        public Task<int> DeleteReviewAsync(int id)
        {
            return reviewRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Review>> GetAllAsync()
        {
            return reviewRepository.GetAllAsync();
        }

        public Task<Review> GetByIdAsync(int id)
        {
            return reviewRepository.GetByIdAsync(id);
        }


    }
}
