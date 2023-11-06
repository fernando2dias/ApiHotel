using Api.Domain.Interfaces;
using AutoMapper;
using Domain.Dtos.Customer;
using Domain.Entities;
using Domain.Interfaces.Services.Customer;
using Domain.Models;
using Domain.Repository;

namespace Service.Services
{
    public class DependentPersonService : IDependentPersonService
    {
        private IDependentPersonRepository _repository;
        private readonly IMapper _mapper;


        public DependentPersonService(IDependentPersonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<DependentPersonEntity> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<DependentPersonEntity>(entity) ?? new DependentPersonEntity();
        }

        public async Task<IEnumerable<DependentPersonEntity>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<DependentPersonEntity>>(listEntity);
        }


        public async Task<IEnumerable<DependentPersonEntity>> GetAllByCustumerId(Guid customerId) 
        {
            var listEntity = await _repository.DependentPersonByCustomer(customerId);
            return _mapper.Map<IEnumerable<DependentPersonEntity>>(listEntity);
        }

        public async Task<DependentPersonEntity> Post(DependentPerson dependent)
        {
            var model = _mapper.Map<DependentPersonModel>(dependent);
            var entity = _mapper.Map<DependentPersonEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<DependentPersonEntity>(result);
        }

        public async Task<DependentPersonEntity> Put(DependentPerson dependent)
        {
            var model = _mapper.Map<DependentPersonModel>(dependent);
            var entity = _mapper.Map<DependentPersonEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<DependentPersonEntity>(result);
        }
    }
}
