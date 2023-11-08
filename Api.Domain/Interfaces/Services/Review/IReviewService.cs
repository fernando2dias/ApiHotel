using Domain.Dtos.Customer;
using Domain.Dtos.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Review
{
    public interface IReviewService
    {
        Task<ReviewDto> Get(Guid id);
        Task<IEnumerable<ReviewDto>> GetAll();
        Task<IEnumerable<ReviewDto>> GetAllByHotel(Guid hotelId);
        Task<IEnumerable<ReviewDto>> GetAllByCustomer(Guid customerId);
        Task<ReviewDtoCreateResult> Post(ReviewDtoCreate review);
        Task<ReviewDtoUpdateResult> Put(ReviewDtoUpdate review);
        Task<bool> Delete(Guid id);
    }
}
