using Api.Data.Context;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class ReviewImplementation : BaseRepository<ReviewEntity>, IReviewRepository
    {
        private DbSet<ReviewEntity> _dataset;
        public ReviewImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ReviewEntity>();
        }
        public async Task<List<ReviewEntity>> FindByCustomer(ReviewEntity review)
        {
            if (review == null || review.Customer == null)
            {
                throw new ArgumentNullException(nameof(review), "Review or its associated Customer cannot be null.");
            }

            var customerId = review.Customer.Id;

            return await _dataset.Where(r => r.Customer.Id == customerId).ToListAsync();
        }

        public async Task<List<ReviewEntity>> FindByHotel(ReviewEntity review)
        {
            if (review == null || review.Hotel == null)
            {
                throw new ArgumentNullException(nameof(review), "Review or its associated Hotel cannot be null.");
            }

            var hotelId = review.Hotel.Id;

            return await _dataset.Where(r => r.Hotel.Id == hotelId).ToListAsync();
        }
    }
}
