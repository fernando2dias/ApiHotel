using Api.Domain.Interfaces;
using AutoMapper;
using Domain.Dtos.Customer;
using Domain.Entities;
using Domain.Interfaces.Services.Customer;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class DependentPersonService : IDependentPersonService
    {
        private IRepository<DependentPersonEntity> _repository;
        private readonly IMapper _mapper;


        public DependentPersonService(IRepository<DependentPersonEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<DependentPersonDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<DependentPersonDto>(entity) ?? new DependentPersonDto();
        }

        public async Task<IEnumerable<DependentPersonDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<DependentPersonDto>>(listEntity);
        }

        public async Task<DependentPersonDtoCreateResult> Post(DependentPersonDtoCreate dependent)
        {
            var model = _mapper.Map<DependentPersonModel>(dependent);
            var entity = _mapper.Map<DependentPersonEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<DependentPersonDtoCreateResult>(result);
        }

        public async Task<DependentPersonDtoUpdateResult> Put(DependentPersonDtoUpdate dependent)
        {
            var model = _mapper.Map<DependentPersonModel>(dependent);
            var entity = _mapper.Map<DependentPersonEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<DependentPersonDtoUpdateResult>(result);
        }
    }
}
