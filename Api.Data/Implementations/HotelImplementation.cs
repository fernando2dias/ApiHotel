using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Repository;
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
    public class HotelImplementation : BaseRepository<HotelEntity>, IHotelRepository
    {
        private DbSet<HotelEntity> _dataset;
        public HotelImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<HotelEntity>();
        }

    }
}
