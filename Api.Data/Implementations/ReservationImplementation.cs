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
    public class ReservationImplementation : BaseRepository<ReservationEntity>, IReservationRepository
    {
        private DbSet<ReservationEntity> _dataset;
        public ReservationImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ReservationEntity>();
        }

        public async Task<ReservationEntity> GetByHotelId(Guid id)
        {
            return await _dataset.Include(r => r.Customer).Include(r => r.Room).Where(r => r.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ReservationEntity>> ReservationByCustomer(Guid id)
        {
            return await _dataset.Include(r => r.Customer).Where(r => r.Customer.Id == id).ToListAsync();
        }

        public async Task<IEnumerable<ReservationEntity>> ReservationByHotel(Guid id)
        {
            return await _dataset.Include(r => r.Room).ThenInclude(r => r.Hotel).Where(r => r.Room.Hotel.Id == id).ToListAsync();
        }
    }
}
