using Domain.Dtos.Customer;
using Domain.Dtos.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Hotel
{
    public interface IHotelService
    {
        Task<HotelDto> Get(Guid id);
        Task<IEnumerable<HotelDto>> GetAll();
        Task<HotelDtoCreateResult> Post(HotelDtoCreate hotel);
        Task<HotelDtoUpdateResult> Put(HotelDtoUpdate hotel);
        Task<bool> Delete(Guid id);
    }
}
