using Api.Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IDependentPersonRepository : IRepository<DependentPersonEntity>
    {
        Task<IEnumerable<DependentPersonEntity>> DependentPersonByCustomer(Guid id);
    }
}
