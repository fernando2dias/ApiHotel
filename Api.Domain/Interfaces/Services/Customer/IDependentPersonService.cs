using Domain.Dtos.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Customer
{
    public interface IDependentPersonService
    {
        Task<DependentPersonDto> Get(Guid id);
        Task<IEnumerable<DependentPersonDto>> GetAll();
        Task<DependentPersonDtoCreateResult> Post(DependentPersonDtoCreate dependent);
        Task<DependentPersonDtoUpdateResult> Put(DependentPersonDtoUpdate dependent);
        Task<bool> Delete(Guid id);

    }
}
