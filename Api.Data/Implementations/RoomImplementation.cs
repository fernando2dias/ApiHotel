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
    public class RoomImplementation : BaseRepository<RoomEntity>, IRoomRepository
    {
        private DbSet<RoomEntity> _dataset;
        public RoomImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<RoomEntity>();
        }

        public Task<RoomEntity> FindByHotel(HotelEntity hotel)
        {
            throw new NotImplementedException();
        }
    }
}
