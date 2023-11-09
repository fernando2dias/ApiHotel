using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ReservationEntity : BaseEntity
    {
        public DateTime ReserveDateInit { get; set; }
        public DateTime ReserveDateEnd { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Guid CustomerId { get; set; }
        public Guid RoomId { get; set; }
        public RoomEntity Room { get; set; }
        public CustomerEntity Customer { get; set; }

    }

}
