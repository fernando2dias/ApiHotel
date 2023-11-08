using Api.Domain.Interfaces;
using AutoMapper;
using Domain.Dtos.Hotel;
using Domain.Entities;
using Domain.Interfaces.Services.Hotel;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RoomService : IRoomService
    {
        private IRepository<RoomEntity> _repository;
        private readonly IMapper _mapper;

        public RoomService(IRepository<RoomEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<RoomDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<RoomDto>(entity) ?? new RoomDto();
        }

        public async Task<IEnumerable<RoomDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<RoomDto>>(listEntity);
        }

        public Task<IEnumerable<RoomDto>> GetAllByHotel(HotelDto hotel)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomDtoCreateResult> Post(RoomDtoCreate room)
        {
            RoomModel roomModel = new RoomModel() {
                HotelId = room.HotelId,
                Number = Int32.Parse(room.Number),
                TypeRoom = room.TypeRoom,
                NumberBeds = room.NumberBeds,
                PricePerNight = room.PricePerNight
            };
          
            var entity = _mapper.Map<RoomEntity>(roomModel);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<RoomDtoCreateResult>(result);
        }

        public async Task<RoomDtoUpdateResult> Put(RoomDtoUpdate room)
        {
            RoomModel roomModel = new RoomModel()
            {
                Id = room.Id,
                HotelId = room.HotelId,
                Number = Int32.Parse(room.Number),
                TypeRoom = room.TypeRoom,
                NumberBeds = room.NumberBeds,
                PricePerNight = room.PricePerNight
            };

            //var model = _mapper.Map<RoomModel>(hotel);
            var entity = _mapper.Map<RoomEntity>(roomModel);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<RoomDtoUpdateResult>(result);
        }
    }
}
