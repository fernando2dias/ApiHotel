using Domain.Dtos.Customer;
using Domain.Entities;

namespace Domain.Interfaces.Services.Customer
{
    public interface IDependentPersonService
    {
        Task<DependentPersonEntity> Get(Guid id);
        Task<IEnumerable<DependentPersonEntity>> GetAll();
        Task<IEnumerable<DependentPersonEntity>> GetAllByCustumerId(Guid customerId);
        Task<DependentPersonEntity> Post(DependentPerson dependent);
        Task<DependentPersonEntity> Put(DependentPerson dependent);
        Task<bool> Delete(Guid id);

    }
}

public record DependentPerson
    (
        Guid? Id,
        string Name,
        string LastName,
        DateTime BirthDate,
        string CPF,
        string RG,
        string Passport,
        CustomerEntity Customer
    );
