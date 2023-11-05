using Domain.Dtos.Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Hotel
{
    public interface IRoomService
    {
        Task<RoomDto> Get(Guid id);
        Task<IEnumerable<RoomDto>> GetAll();
        Task<IEnumerable<RoomDto>> GetAllByHotel(HotelDto hotel);
        Task<RoomDtoCreateResult> Post(RoomDtoCreate room);
        Task<RoomDtoUpdateResult> Put(RoomDtoUpdate hotel);
        Task<bool> Delete(Guid id);
    }
}
