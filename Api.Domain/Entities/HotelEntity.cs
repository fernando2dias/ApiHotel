using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HotelEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public Decimal AvgTicket { get; set; }
        public List<RoomEntity> Rooms { get; set; }
    }
}
