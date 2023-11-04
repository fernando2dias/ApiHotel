using Domain.Dtos.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Customer
{
    public interface ICustomerService
    {
        Task<CustomerDto> Get(Guid id);
        Task<IEnumerable<CustomerDto>> GetAll();
        Task<CustomerDtoCreateResult> Post(CustomerDtoCreate customer);
        Task<CustomerDtoUpdateResult> Put(CustomerDtoUpdate customer);
        Task<bool> Delete(Guid id);

    }
}
