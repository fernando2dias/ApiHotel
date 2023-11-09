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
        public async Task<List<ReviewEntity>> FindByCustomer(Guid customerId)
        {
            return await _dataset.Where(r => r.CustomerId == customerId).ToListAsync();
        }

        public async Task<List<ReviewEntity>> FindByHotel(Guid hotelId)
        {
            return await _dataset.Where(r => r.HotelId == hotelId).ToListAsync();
        }
    }
}
