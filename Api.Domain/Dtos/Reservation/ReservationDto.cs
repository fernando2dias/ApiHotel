using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Reservation
{
    public class ReservationDto
    {
        public DateTime ReserveDateInit { get; set; }
        public DateTime ReserveDateEnd { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Guid CustomerId { get; set; }
        public Guid RoomId { get; set; }
    }
}
