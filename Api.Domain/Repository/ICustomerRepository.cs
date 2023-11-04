using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface ICustomerRepository : IRepository<CustomerEntity>
    {
        Task<CustomerEntity> FindByEmail(string email);
        Task<CustomerEntity> FindByDocument(string document);
    }
}
