using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Models;
using AutoMapper;
using Domain.Dtos.Customer;
using Domain.Entities;
using Domain.Interfaces.Services.Customer;
using Domain.Models;

namespace Service.Services
{
    public class CustomerService : ICustomerService
    {
        private IRepository<CustomerEntity> _repository;
        private readonly IMapper _mapper;

        public CustomerService(IRepository<CustomerEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CustomerDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<CustomerDto>>(listEntity);
        }

        public async Task<CustomerDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<CustomerDto>(entity) ?? new CustomerDto();
        }

        public async Task<CustomerDtoCreateResult> Post(CustomerDtoCreate customer)
        {
            var model = _mapper.Map<CustomerModel>(customer);
            var entity = _mapper.Map<CustomerEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<CustomerDtoCreateResult>(result);
        }

        public async Task<CustomerDtoUpdateResult> Put(CustomerDtoUpdate customer)
        {
            var model = _mapper.Map<CustomerModel>(customer);
            var entity = _mapper.Map<CustomerEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<CustomerDtoUpdateResult>(result);
        }
    }
}
