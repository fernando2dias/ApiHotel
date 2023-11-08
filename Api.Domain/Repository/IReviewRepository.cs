using Api.Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IReviewRepository : IRepository<ReviewEntity>
    {
        Task<List<ReviewEntity>> FindByHotel(Guid hotelId);
        Task<List<ReviewEntity>> FindByCustomer(Guid customerId);
    }
}
