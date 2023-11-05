using Api.Domain.Interfaces;
using AutoMapper;
using Domain.Dtos.Customer;
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
    public class HotelService : IHotelService
    {
        private IRepository<HotelEntity> _repository;
        private readonly IMapper _mapper;

        public HotelService(IRepository<HotelEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<HotelDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<HotelDto>(entity) ?? new HotelDto();
        }

        public async Task<IEnumerable<HotelDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<HotelDto>>(listEntity);
        }

        public async Task<HotelDtoCreateResult> Post(HotelDtoCreate hotel)
        {
            var model = _mapper.Map<HotelModel>(hotel);
            var entity = _mapper.Map<HotelEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<HotelDtoCreateResult>(result);
        }

        public async Task<HotelDtoUpdateResult> Put(HotelDtoUpdate hotel)
        {
            var model = _mapper.Map<HotelModel>(hotel);
            var entity = _mapper.Map<HotelEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<HotelDtoUpdateResult>(result);
        }
    }
}
