using Api.Data.Context;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class DependentPersonImplementation : BaseRepository<DependentPersonEntity>, IDependentPersonRepository
    {
        private DbSet<DependentPersonEntity> _dataset;
        public DependentPersonImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<DependentPersonEntity>();
        }

        public async Task<IEnumerable<DependentPersonEntity>> DependentPersonByCustomer(Guid id)
        {
            return await _dataset.Include(d => d.Customer).Where(d => d.Customer.Id == id).ToListAsync();
        }
    }
}
