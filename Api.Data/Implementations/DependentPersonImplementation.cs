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
    }
}
