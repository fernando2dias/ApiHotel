using Api.Data.Context;
using Api.Domain.Entities;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class CustomerImplementation : BaseRepository<CustomerEntity>, ICustomerRepository
    {
        private DbSet<CustomerEntity> _dataset;
        public CustomerImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CustomerEntity>();
        }

        public async Task<CustomerEntity> FindByDocument(string document)
        {
            var result = await _dataset
                .Where(c => c.CPF.Equals(document) || c.RG.Equals(document) || c.Passport.Equals(document))
                .FirstOrDefaultAsync();
            return result;

        }

        public async Task<CustomerEntity> FindByEmail(string email)
        {
            return await _dataset.FirstOrDefaultAsync(c => c.Email.Equals(email));
        }
    }
}
